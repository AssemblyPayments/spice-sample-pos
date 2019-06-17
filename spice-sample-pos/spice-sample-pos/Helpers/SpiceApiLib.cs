using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.VisualStyles;
using Flurl;
using Flurl.Http;
using spice_sample_pos.Models;

namespace spice_sample_pos.Helpers
{
    public static class SpiceApiLib
    {
        private const string HeaderPosName = "POS-Name";
        private const string HeaderPosVersion = "POS-Version";

        // TODO: Extension methods, abstract error handling and headers

        public static string Purchase(string posRefId, int purchaseAmountCents, int tipAmountCents,
            int cashoutAmountCents, bool promptForCashout, int surchargeAmountCents, string headerPosName, string headerPosVersion)
        {
            var purchaseRequest = new PurchaseRequest
            {
                PosRefId = posRefId,
                PurchaseAmountCents = purchaseAmountCents,
                TipAmountCents = tipAmountCents,
                CashOutAmountCents = cashoutAmountCents,
                PromptForCashout = promptForCashout,
                SurchargeAmountCents = surchargeAmountCents
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("purchase")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(purchaseRequest).ConfigureAwait(false);

                return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                return ex.Message;
            }
            catch (FlurlHttpException ex)
            {
                return ex.Message;
            }
        }

        public static string Moto(string posRefId, int purchaseAmountCents, int surchargeAmountCents,
            bool suppressMerchantPassword, string headerPosName, string headerPosVersion)
        {
            var motoRequest = new MotoRequest
            {
                PosRefId = posRefId,
                PurchaseAmountCents = purchaseAmountCents,
                SurchargeAmountCents = surchargeAmountCents,
                SuppressMerchantPassword = suppressMerchantPassword
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("moto")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(motoRequest).ConfigureAwait(false);

                return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                return ex.Message;
            }
            catch (FlurlHttpException ex)
            {
                return ex.Message;
            }
        }

        public static string Refund(string posRefId, int refundAmountCents, bool suppressMerchantPassword, string headerPosName, string headerPosVersion)
        {
            var refundRequest = new RefundRequest
            {
                PosRefId = posRefId,
                RefundAmountCents = refundAmountCents,
                SuppressMerchantPassword = suppressMerchantPassword
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("refund")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(refundRequest).ConfigureAwait(false);

                return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                return ex.Message;
            }
            catch (FlurlHttpException ex)
            {
                return ex.Message;
            }
        }

        public static string SettlementEnquiry(string posRefId, string headerPosName, string headerPosVersion)
        {
            var SettlementEnquiry = new SettlementEnquiryRequest()
            {
                PosRefId = posRefId,
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("settlement_enquiry")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(SettlementEnquiry).ConfigureAwait(false);

                return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                return ex.Message;
            }
            catch (FlurlHttpException ex)
            {
                return ex.Message;
            }
        }

        public static string PayAtTable(string headerPosName, string headerPosVersion)
        {
            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("pat")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .GetAsync().ConfigureAwait(false);

                return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                return ex.Message;
            }
            catch (FlurlHttpException ex)
            {
                // need to log and call it again
                PayAtTable("posname", "posversion");
                return ex.Message;
            }
        }

    }
}
