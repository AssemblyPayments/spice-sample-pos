using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using spice_sample_pos.Helpers;
using spice_sample_pos.Models;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace spice_sample_pos
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();

            // material skin intiailisation
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void tsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionButtonControl();
        }

        private void ActionButtonControl()
        {
            var buttonText = string.Empty;

            switch (tcMain.SelectedTab.Name)
            {
                case "Purchase":
                    buttonText = "Purchase";
                    break;
                case "Refund":
                    buttonText = "Refund";
                    break;
                default:
                    break;
            }

            btnAction.Text = buttonText;
        }

        private async void btnAction_Click(object sender, EventArgs e)
        {
            var parsed = false;

            switch (btnAction.Text)
            {
                case "Purchase":
                    parsed = int.TryParse(txtPurchase.Text, out var purchaseAmountCents);

                    if (parsed)
                    {
                        var purchaseAmount = purchaseAmountCents * 100;
                        var response = SpiceApiLib.Purchase(PosRefIdHelper(), purchaseAmount, 0, 0, false, 0);

                        DisplayReceipt(response);
                    }
                    break;
                case "Refund":
                    parsed = int.TryParse(txtRefund.Text, out var refundAmountCents);

                    if (parsed)
                    {
                        var purchaseAmount = refundAmountCents * 100;
                        var response = await SpiceApiLib.Refund(PosRefIdHelper(), purchaseAmount, 0, 0, false, 0);
                    }
                    break;
                case "OK":
                    pnlResult.SendToBack();
                    lblResult.Text = string.Empty;
                    ActionButtonControl();
                    break;
                default:
                    break;
            }
        }

        private void DisplayReceipt(string data)
        {
            var result = (JObject) JsonConvert.DeserializeObject(data);
            var error = result.GetValue("error", StringComparison.OrdinalIgnoreCase);

            pnlResult.BringToFront();
            lblResult.Text = error != null ? error.ToString() : (string) result.SelectToken("Response[0].customer_receipt");
            btnAction.Text = "OK";
        }

        private static string PosRefIdHelper()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
