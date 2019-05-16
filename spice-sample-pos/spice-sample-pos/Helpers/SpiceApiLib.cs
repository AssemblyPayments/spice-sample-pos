using Flurl;
using Flurl.Http;
using System.Net;
using spice_sample_pos.Models.Requests;
using System.Threading.Tasks;

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
                SurchageAmountCents = surchargeAmountCents
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

        public static string Refund(string posRefId, int refundAmountCents, string headerPosName, string headerPosVersion)
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

        //public async static Task<string> PayAtTable(string headerPosName, string headerPosVersion)
        //{
        //    try
        //    {
        //        var response = await "http://localhost:8282/v1"
        //            .AppendPathSegment("pat")
        //            .WithHeader(HeaderPosName, headerPosName)
        //            .WithHeader(HeaderPosVersion, headerPosVersion)
        //            .GetAsync().ConfigureAwait(true);

        //        return await response.Content.ReadAsStringAsync();
        //    }
        //    catch (System.Exception ex) //TODO: Fix this
        //    {
        //        throw ex;
        //    }
        //}

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
            catch (System.Exception ex) //TODO: Fix this
            {
                throw ex;
            }
        }


        public static string PayAtTable(string tableId, int outstandingAmount, int totalAmount, string billId, string headerPosName, string headerPosVersion)
        {
            var PayAtTableEnquiry = new PayAtTableRequest() // TODO. Fix this
            {
                BillId = frmMain.PosRefIdHelper(),
                OutstandingAmount = 340,
                Result = "SUCCESS", 
                TableId = "1",
                TotalAmount = 340
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("pat")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(PayAtTableEnquiry).ConfigureAwait(false);

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
