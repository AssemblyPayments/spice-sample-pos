using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using spice_sample_pos.Helpers;
using System;
using System.Net.Http;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;

namespace spice_sample_pos
{
    public partial class frmMain : MaterialForm
    {
        private readonly CultureInfo _cultureInfo = new CultureInfo("en-Au");
        private const string PosName = "HabaneroPos";
        private readonly string _posVersion = Assembly.GetEntryAssembly()?.GetName().Version.ToString();
        private static readonly Properties.Settings Settings = Properties.Settings.Default;

        private enum TransactionType { purchase, refund };

        public frmMain()
        {
            InitializeComponent();

            // timer for adaptor status
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnRefreshAdaptorStatus;
            timer.Enabled = true;

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

            // invoke recovery
            InvokeRecovery();
        }

        private void OnRefreshAdaptorStatus(object source, ElapsedEventArgs e)
        {
            DisplayAdaptorStatus();
        }

        private void tsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            const string moneyDefault = @"0";

            pnlResult.SendToBack();

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
            txtZipPurchase.Text = moneyDefault;
            txtZipRefund.Text = moneyDefault;
            txtZipPurchaseDesc.Text = "";
            txtZipReceiptNumber.Text = "";

            switch (tcMain.SelectedTab.Name)
            {
                case "Purchase":
                    btnAction.Text = "Purchase";
                    break;
                case "MOTO":
                    btnAction.Text = "MOTO";
                    break;
                case "Refund":
                    btnAction.Text = "Refund";
                    break;
                case "SettlementEnquiry":
                    btnAction.Text = "Enquiry";
                    break;
                case "PayAtTable":
                    btnAction.Text = "Pay at Table";
                    break;
                case "ZipPurchase":
                    btnAction.Text = "Zip Purchase";
                    break;
                case "ZipRefund":
                    btnAction.Text = "Zip Refund";
                    break;
                default:
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            // set transaction incomplete
            Settings.TransactionComplete = false;
            Settings.TransactionState = btnAction.Text;
            Settings.Save();

            if (string.Equals(btnAction.Text, "OK"))
            {
                lblResult.Text = string.Empty;
                ResetControls();
                return;
            }

            if (!IsAdaptorPaired())
            {
                DisplayResultHelper("Please check your adaptor");
                return;
            }

            switch (tcMain.SelectedTab.Name)
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

                        if (response.IsSuccessStatusCode)
                        {
                            DisplayResult(response.Content.ReadAsStringAsync().Result);
                            IsSignatureRequired(response.Content.ReadAsStringAsync().Result, TransactionType.purchase);
                        }
                        else if (response.StatusCode == HttpStatusCode.RequestTimeout)
                        {
                            // Manual Override https://developer.assemblypayments.com/docs/manual-user-override
                        }
                    }

                    break;
                case "ZipPurchase":
                    bool zipPurchaseParsed;

                    zipPurchaseParsed = int.TryParse(txtZipPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var zipPurchaseAmount);

                    if (zipPurchaseParsed)
                    {
                        var response = SpiceApiLib.ZipPurchase(PosRefIdHelper(), zipPurchaseAmount, txtZipPurchaseDesc.Text, PosName, _posVersion);

                        if (response.IsSuccessStatusCode)
                        {
                            DisplayResult(response.Content.ReadAsStringAsync().Result);
                        }
                        else if (response.StatusCode == HttpStatusCode.RequestTimeout)
                        {
                            // Manual Override https://developer.assemblypayments.com/docs/manual-user-override
                        }
                    }

                    break;
                case "MOTO":
                    bool motoPurchaseParsed, motoSurchargeParsed;

                    motoPurchaseParsed = int.TryParse(txtMotoPurchase.Text, NumberStyles.Currency, this._cultureInfo, out var motoPurchaseAmount);
                    motoSurchargeParsed = int.TryParse(txtMotoSurcharge.Text, NumberStyles.Currency, this._cultureInfo, out var motoSurchargeAmount);

                    if (motoPurchaseParsed && motoSurchargeParsed)
                    {
                        var response = SpiceApiLib.Moto(PosRefIdHelper(), motoPurchaseAmount, motoSurchargeAmount, rbSuppressPasswordYes.Checked, PosName, _posVersion);

                        if (response.IsSuccessStatusCode)
                        {
                            DisplayResult(response.Content.ReadAsStringAsync().Result);
                        }
                    }

                    break;
                case "Refund":
                    bool refundParsed;

                    refundParsed = int.TryParse(txtZipRefund.Text, NumberStyles.Currency, this._cultureInfo, out var refundAmount);

                    if (refundParsed)
                    {
                        var response = SpiceApiLib.Refund(PosRefIdHelper(), refundAmount, rbRefundSuppressPasswordYes.Checked, PosName, _posVersion);

                        if (response.IsSuccessStatusCode)
                        {
                            DisplayResult(response.Content.ReadAsStringAsync().Result);
                            IsSignatureRequired(response.Content.ReadAsStringAsync().Result, TransactionType.refund);
                        }
                        else if (response.StatusCode == HttpStatusCode.RequestTimeout)
                        {
                            // Manual Override https://developer.assemblypayments.com/docs/manual-user-override
                        }
                    }

                    break;
                case "ZipRefund":
                    bool zipRefundParsed;

                    zipRefundParsed = int.TryParse(txtZipRefund.Text, NumberStyles.Currency, this._cultureInfo, out var zipRefundAmount);

                    if (zipRefundParsed)
                    {
                        var response = SpiceApiLib.ZipRefund(PosRefIdHelper(), zipRefundAmount, txtZipReceiptNumber.Text, PosName, _posVersion);

                        if (response.IsSuccessStatusCode)
                        {
                            DisplayResult(response.Content.ReadAsStringAsync().Result);
                            IsSignatureRequired(response.Content.ReadAsStringAsync().Result, TransactionType.refund);
                        }
                        else if (response.StatusCode == HttpStatusCode.RequestTimeout)
                        {
                            // Manual Override https://developer.assemblypayments.com/docs/manual-user-override
                        }
                    }

                    break;
                case "SettlementEnquiry":
                    var enquiry = SpiceApiLib.SettlementEnquiry(PosRefIdHelper(), PosName, _posVersion);
                    DisplayResult(enquiry.Content.ReadAsStringAsync().Result);

                    break;
             
                case "Pay at Table":
                    break;
            }

            Settings.TransactionComplete = true;
            Settings.Save();
        }

        public void DisplayAdaptorStatus()
        {
            var status = SpiceApiLib.Ping(PosName, _posVersion);

            if (!status.IsSuccessStatusCode)
                return;

            DisplayResult(status.Content.ReadAsStringAsync().Result);
        }

        private bool IsAdaptorPaired()
        {
            var status = SpiceApiLib.Ping(PosName, _posVersion);

            if (!status.IsSuccessStatusCode)
                return false;

            var result = (JObject)JsonConvert.DeserializeObject(status.Content?.ReadAsStringAsync().Result);
            var paired = result.SelectToken("status");

            return paired.ToString() == "PairedConnected";
        }

        /// <summary>
        /// Recovery for when the PoS crashes
        /// </summary>
        private void InvokeRecovery()
        {
            var currentPosRefId = Settings.CurrentPosRefId;

            // no need for recovery
            if (Settings.TransactionComplete || currentPosRefId == "")
                return;

            // initiate recovery
            switch (Settings.TransactionState)
            {
                case "MOTO":
                    var motoRecovery = SpiceApiLib.Moto(currentPosRefId, PosName, _posVersion);

                    if (motoRecovery.IsSuccessStatusCode)
                    {
                        DisplayResult(motoRecovery.Content.ReadAsStringAsync().Result);
                    }

                    break;
                case "Purchase":
                    var purchaseRecovery = SpiceApiLib.Purchase(currentPosRefId, PosName, _posVersion);

                    if (purchaseRecovery.IsSuccessStatusCode)
                    {
                        DisplayResult(purchaseRecovery.Content.ReadAsStringAsync().Result);
                    }

                    break;
                case "Refund":
                    var refundRecovery = SpiceApiLib.Refund(currentPosRefId, PosName, _posVersion);

                    if (refundRecovery.IsSuccessStatusCode)
                    {
                        DisplayResult(refundRecovery.Content.ReadAsStringAsync().Result);
                    }

                    break;
            }

            // transaction complete
            Settings.TransactionComplete = true;
            Settings.Save();
        }

        private void IsSignatureRequired(string data, TransactionType transactionType)
        {
            HttpResponseMessage response;

            // https://developer.assemblypayments.com/docs/signature-transaction
            var currentPosRefId = Settings.CurrentPosRefId;

            // check if signature is required
            var result = (JObject)JsonConvert.DeserializeObject(data); // need a better way
            var value = result.GetValue("signatureRequired", StringComparison.OrdinalIgnoreCase);

            if (value == null)
                return;

            // signature accept or decline, get result from Assembly Payments Adaptor
            if (transactionType == 0)
            {
                response = SpiceApiLib.Purchase(currentPosRefId, PosName, _posVersion);
            }
            else
            {
                response = SpiceApiLib.Refund(currentPosRefId, PosName, _posVersion);
            }

            // customer receipt
            DisplayResult(response.Content.ReadAsStringAsync().Result);

            return;
        }

        // This needs to be refactored
        private void DisplayResult(string data)
        {
            try
            {
                var result = (JObject)JsonConvert.DeserializeObject(data);

                var error = result.GetValue("error", StringComparison.OrdinalIgnoreCase);
                if (error != null)
                {
                    DisplayResultHelper(error.ToString());
                    return;
                }

				// customer receipt
				var receipt = result.SelectToken("Response.customer_receipt");
				if (receipt != null)
				{
					DisplayResultHelper(receipt.ToString());
					return;
				}

				// merchant receipt - signature
				var signatureRequired = result.SelectToken("signatureRequired.receiptToSign");
				if (signatureRequired != null)
				{
					DisplayResultHelper(signatureRequired.ToString());
					return;
				}

				var errorDetail = result.SelectToken("Response.error_detail");
                if (errorDetail != null)
                {
                    DisplayResultHelper(errorDetail.ToString());
                    return;
                }

                // check to see if it is a user override
                var userOverride = result.SelectToken("Response.user_override");
                if (userOverride?.ToString().ToLower() == "true")
                {
                    var successful = result.SelectToken("Response.success").ToString().ToLower() == "true" ? "successful" : "unsuccessful";
                    DisplayResultHelper($"Manual Eftpos - The transaction was {successful}");
                    return;
                }

                var status = result.SelectToken("status");
                if (status != null)
                {
                    DisplayStatusResultHelper(result);
                    return;
                }
            }
            catch
            {
                DisplayResultHelper(data);
                return;
            }
        }

        private void DisplayResultHelper(string displayText)
        {
            lblResult.Text = displayText;
            pnlResult.BringToFront();
            btnAction.Text = "OK";
        }

        private void DisplayStatusResultHelper(JObject result)
        {
            DateTime dateTime = DateTime.Now;

            var parse = DateTime.TryParse(result.SelectToken("pong").ToString(), out DateTime parsedValue);

            if (parse)
            {
                dateTime = parsedValue.ToLocalTime();
            }

            Invoke(new MethodInvoker(delegate ()
            {
                lblCurrentAdaptorStatus.Text = "Adaptor Status: " + result.SelectToken("status").ToString() + " " + dateTime.ToString() + " " + result.SelectToken("flow").ToString();
            }));
        }

        private static string PosRefIdHelper()
        {
            Settings.CurrentPosRefId = Guid.NewGuid().ToString("N");
            Settings.Save();

            return Settings.CurrentPosRefId;
        }
    }
}
