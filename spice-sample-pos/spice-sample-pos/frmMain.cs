using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using spice_sample_pos.Helpers;
using spice_sample_pos.Models;

namespace spice_sample_pos
{
    public partial class frmMain : MaterialForm
    {
        private readonly CultureInfo _cultureInfo = new CultureInfo("en-Au");
        private const string PosName = "HabaneroPos";
        private readonly string _posVersion = Assembly.GetEntryAssembly()?.GetName().Version.ToString();
        private readonly Timer _timer = new Timer();
        private readonly BackgroundWorker _worker = new BackgroundWorker();

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

            // start timer for ping
            _timer.Tick += timer_Tick;
            _timer.Interval = 5000;
            _timer.Enabled = true;
            _worker.DoWork += worker_DoWork;
            // let's invoke it straight away
            UpdatePing();
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (InvokeRequired) // use background worker, this might cause race conditions
            {
                Invoke(new Action(UpdatePing));
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }


        private void tsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void UpdatePing()
        {
            var response = SpiceApiLib.Ping(PosName, _posVersion);
            dynamic parse = JsonConvert.DeserializeObject(response);

            lblPingStatus.Text = ($@"Version: {parse.version}     Status: {parse.status}     Flow: {parse.flow}     Last Pong: {parse.pong}");
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
                case "MOTO":
                    buttonText = "MOTO";
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
            txtSurcharge.Text = moneyDefault;
            txtTip.Text = moneyDefault;
            rbCashoutNo.Checked = true;
            rbRefundSuppressPasswordNo.Checked = true;
            txtMotoPurchase.Text = moneyDefault;
            txtMotoSurcharge.Text = moneyDefault;
            btnAction.Text = buttonText;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (btnAction.Text)
            {
                case "Purchase":
                    bool purchaseParsed, cashoutParsed, tipParsed, surchargeParsed;

                    purchaseParsed = int.TryParse(txtPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var purchaseAmount);
                    cashoutParsed = int.TryParse(txtCashout.Text, NumberStyles.Currency, this._cultureInfo, out var cashoutAmount);
                    tipParsed = int.TryParse(txtTip.Text, NumberStyles.Currency, this._cultureInfo, out var tipAmount);
                    surchargeParsed = int.TryParse(txtSurcharge.Text, NumberStyles.Currency, this._cultureInfo, out var surchargeAmount);

                    if (purchaseParsed && cashoutParsed && tipParsed && surchargeParsed)
                    {
                        var response = SpiceApiLib.Purchase(PosRefIdHelper(), purchaseAmount, tipAmount, cashoutAmount, rbCashoutYes.Checked, surchargeAmount, PosName, _posVersion);
                        DisplayResult(response);
                    }

                    break;
                case "MOTO":
                    bool motoPurchaseParsed, motoSurchargeParsed;

                    motoPurchaseParsed = int.TryParse(txtMotoPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var motoPurchaseAmount);
                    motoSurchargeParsed = int.TryParse(txtMotoSurcharge.Text, NumberStyles.Currency, this._cultureInfo, out var motoSurchargeAmount);

                    if (motoPurchaseParsed && motoSurchargeParsed)
                    {
                        var response = SpiceApiLib.Moto(PosRefIdHelper(), motoPurchaseAmount, motoSurchargeAmount, rbSuppressPasswordYes.Checked, PosName, _posVersion);
                        DisplayResult(response);
                    }

                    break;
                case "Refund":
                    bool refundParsed;

                    refundParsed = int.TryParse(txtRefund.Text, NumberStyles.Currency, this._cultureInfo, out var refundAmount);

                    if (refundParsed)
                    {
                        var response = SpiceApiLib.Refund(PosRefIdHelper(), refundAmount, rbRefundSuppressPasswordYes.Checked, PosName, _posVersion);
                        DisplayResult(response);
                    }

                    break;
                case "Enquiry":
                    var enquiry = SpiceApiLib.SettlementEnquiry(PosRefIdHelper(), PosName, _posVersion);
                    DisplayResult(enquiry);

                    break;
                case "Pay at Table":
                    var payAtTable = SpiceApiLib.PayAtTable(PosName, _posVersion);

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
