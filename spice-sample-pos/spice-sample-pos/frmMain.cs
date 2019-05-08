using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
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
        // pay at table
        public static Dictionary<string, PayAtTableBills> patBillStore = new Dictionary<string, PayAtTableBills>(); // billId, Bills
        public static Dictionary<string, string> patTableToBillMapping = new Dictionary<string, string>(); // tableId, billId

        private readonly CultureInfo _cultureInfo = new CultureInfo("en-Au");
        private const string PosName = "HabaneroPos";
        private readonly string PosVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();

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

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            const string moneyDefault = @"0";
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
                case "PayAtTable":
                    buttonText = "Pay at Table";
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (btnAction.Text)
            {
                case "Purchase":
                    bool purchaseParsed, cashoutParsed, tipParsed;

                    purchaseParsed = int.TryParse(txtPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var purchaseAmount);
                    cashoutParsed = int.TryParse(txtCashout.Text, NumberStyles.Currency, this._cultureInfo, out var cashoutAmount);
                    tipParsed = int.TryParse(txtTip.Text, NumberStyles.Currency, this._cultureInfo, out var tipAmount);

                    if (purchaseParsed && cashoutParsed && tipParsed)
                    {
                        var response = SpiceApiLib.Purchase(PosRefIdHelper(), purchaseAmount, tipAmount, cashoutAmount, false, 0, PosName, PosVersion);
                        DisplayResult(response);
                    }

                    break;
                case "Refund":
                    bool refundParsed;

                    refundParsed = int.TryParse(txtRefund.Text, NumberStyles.Currency, this._cultureInfo, out var refundAmount);

                    if (refundParsed)
                    {
                        var response = SpiceApiLib.Refund(PosRefIdHelper(), refundAmount, PosName, PosVersion);
                        DisplayResult(response);
                    }

                    break;
                case "Enquiry":
                    var enquiry = SpiceApiLib.SettlementEnquiry(PosRefIdHelper(), PosName, PosVersion);
                    DisplayResult(enquiry);

                    break;
                case "Pay at Table":
                    var payAtTable = SpiceApiLib.PayAtTable(PosName, PosVersion);

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

        private void BtnTable1_Click(object sender, EventArgs e)
        {
            var frmPAT = new frmPAT("1");
            frmPAT.FormClosed += new FormClosedEventHandler(PatFrmClosed);
            this.Opacity = 0.4;
            frmPAT.ShowDialog();
        }
        private void BtnTable2_Click(object sender, EventArgs e)
        {
            var frmPAT = new frmPAT("2");
            frmPAT.FormClosed += new FormClosedEventHandler(PatFrmClosed);
            this.Opacity = 0.4;
            frmPAT.ShowDialog();
        }

        private void PatFrmClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

    }
}
