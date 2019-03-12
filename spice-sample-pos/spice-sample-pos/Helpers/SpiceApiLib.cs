using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using spice_sample_pos.Models;

namespace spice_sample_pos.Helpers
{
    public static class SpiceApiLib
    {
        public static string Purchase(string posRefId, int purchaseAmount, int tipAmount,
            int cashoutAmount, bool promptForCashout, int surchargeAmount)
        {
            var purchaseRequest = new PurchaseRequest
            {
                PosRefId = posRefId,
                PurchaseAmount = purchaseAmount,
                TipAmount = tipAmount,
                CashOutAmount = cashoutAmount,
                PromptForCashout = promptForCashout,
                SurchageAmount = surchargeAmount
            };

            var response = "http://localhost:8282/v1"
                .AppendPathSegment("purchase")
                .PostJsonAsync(purchaseRequest).ConfigureAwait(false);

            return response.GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;
        }

        public static async Task<HttpResponseMessage> Refund(string posRefId, int purchaseAmount, int tipAmount,
            int cashoutAmount, bool promptForCashout, int surchargeAmount)
        {
            var purchaseRequest = new PurchaseRequest
            {
                PosRefId = posRefId,
                PurchaseAmount = purchaseAmount,
                TipAmount = tipAmount,
                CashOutAmount = cashoutAmount,
                PromptForCashout = promptForCashout,
                SurchageAmount = surchargeAmount
            };

            var response = await "http://localhost:8282/v1"
                .AppendPathSegment("refund")
                .PostJsonAsync(purchaseRequest).ConfigureAwait(false);

            return response;
        }
    }
}
