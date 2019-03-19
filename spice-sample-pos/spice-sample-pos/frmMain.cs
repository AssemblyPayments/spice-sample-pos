using System;
using System.Globalization;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using spice_sample_pos.Helpers;
using spice_sample_pos.Models;

namespace spice_sample_pos
{
    public partial class frmMain : MaterialForm
    {
        private CultureInfo _cultureInfo = new CultureInfo("en-Au"); 

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
            ResetControls();
        }

        private void ResetControls()
        {
            const string moneyDefault = @"0.00";
            var buttonText = string.Empty;

            pnlResult.SendToBack();

            switch (tcMain.SelectedTab.Name)
            {
                case "Purchase":
                    buttonText = "Purchase";
                    break;
                case "Refund":
                    buttonText = "Refund";
                    break;
                case "SettlementEnquiry":
                    buttonText = "Enquiry";
                    break;
                default:
                    break;
            }

            txtCashout.Text = moneyDefault;
            txtPurchase.Text = moneyDefault;
            txtCashout.Text = moneyDefault;
            txtRefund.Text = moneyDefault;
            btnAction.Text = buttonText;
        }

        private async void btnAction_Click(object sender, EventArgs e)
        {
            switch (btnAction.Text)
            {
                case "Purchase":
                    var purchaseParsed = false;
                    var cashoutParsed = false;
                    var tipParsed = false;

                    purchaseParsed = int.TryParse(txtPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var purchaseAmount);
                    cashoutParsed = int.TryParse(txtCashout.Text, NumberStyles.Currency, this._cultureInfo, out var cashoutAmount);
                    tipParsed = int.TryParse(txtTip.Text, NumberStyles.Currency, this._cultureInfo, out var tipAmount);

                    if (purchaseParsed && cashoutParsed && tipParsed)
                    {
                        var purchaseAmountCents = purchaseAmount * 100;
                        var cashoutAmountCents = cashoutAmount * 100;
                        var tipAmountCents = tipAmount * 100;
                        
                        var response = SpiceApiLib.Purchase(PosRefIdHelper(), purchaseAmountCents, tipAmountCents, cashoutAmountCents, false, 0);

                        DisplayResult(response);
                    }
                    break;
                case "Refund":
                    var refundParsed = false;

                    refundParsed = int.TryParse(txtRefund.Text, NumberStyles.Currency, this._cultureInfo, out var refundAmount);

                    if (refundParsed)
                    {
                        var refundAmountCents = refundAmount * 100;
                        var response = SpiceApiLib.Refund(PosRefIdHelper(), refundAmountCents);

                        DisplayResult(response);
                    }
                    break;
                case "Enquiry":
                    var enquiry = SpiceApiLib.SettlementEnquiry(PosRefIdHelper());

                    DisplayResult(enquiry);
                    break;
                case "OK":
                    lblResult.Text = string.Empty;
                    ResetControls();
                    break;
                default:
                    break;
            }
        }

        private void DisplayResult(string data)
        {
            // temp error handling
            try
            {
                var obj = JToken.Parse(data);
            }
            catch
            {
                DisplayResultHelper(data);
                return;
            }

            var result = (JObject) JsonConvert.DeserializeObject(data);

            var error = result.GetValue("error", StringComparison.OrdinalIgnoreCase);
            if (error != null)
            {
                DisplayResultHelper(error.ToString());
                return;
            }

            var errorDetail = result.SelectToken("Response.error_detail");
            if (errorDetail != null)
            {
                DisplayResultHelper(errorDetail.ToString());
                return;
            }

            var receipt = result.SelectToken("Response.customer_receipt");
            if (receipt != null)
            {
                DisplayResultHelper(receipt.ToString());
            }
        }

        private void DisplayResultHelper(string displayText)
        {
            lblResult.Text = displayText;
            pnlResult.BringToFront();
            btnAction.Text = "OK";
        }

        private static string PosRefIdHelper()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
