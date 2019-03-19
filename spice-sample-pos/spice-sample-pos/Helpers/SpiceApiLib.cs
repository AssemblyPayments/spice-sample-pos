using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using spice_sample_pos.Models;

namespace spice_sample_pos.Helpers
{
    public static class SpiceApiLib
    {
        // TODO: Extension methods, abstract error handling

        public static string Purchase(string posRefId, int purchaseAmountCents, int tipAmountCents,
            int cashoutAmountCents, bool promptForCashout, int surchargeAmountCents)
        {
            var purchaseRequest = new PurchaseRequest
            {
                PosRefId = posRefId,
                PurchaseAmountCents = purchaseAmountCents,
                TipAmountCents = tipAmountCents,
                CashOutAmountCents = cashoutAmountCents,
                PromptForCashout = promptForCashout,
                SurchageAmountCents = surchargeAmountCents
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("purchase")
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

        public static string Refund(string posRefId, int refundAmountCents)
        {
            var refundRequest = new RefundRequest
            {
                PosRefId = posRefId,
                RefundAmountCents = refundAmountCents
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("refund")
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

        public static string SettlementEnquiry(string posRefId)
        {
            var refundRequest = new SettlementEqnuiryRequest()
            {
                PosRefId = posRefId,
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("settlement_enquiry")
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
    }
}
