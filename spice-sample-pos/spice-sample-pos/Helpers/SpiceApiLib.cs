using System;
using System.Net;
using System.Net.Http;
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

        public static HttpResponseMessage Purchase(string posRefId, int purchaseAmountCents, int tipAmountCents,
            int cashoutAmountCents, bool promptForCashout, int surchargeAmountCents, string headerPosName,
            string headerPosVersion)
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
                    .PostJsonAsync(purchaseRequest)
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Purchase(string posRefId, string headerPosName, string headerPosVersion)
        {
            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("purchase")
                    .SetQueryParams(new
                    {
                        posRefId
                    })
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .GetAsync().Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Moto(string posRefId, int purchaseAmountCents, int surchargeAmountCents,
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
                    .PostJsonAsync(motoRequest)
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Moto(string posRefId, string headerPosName, string headerPosVersion)
        {
            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("moto")
                    .SetQueryParams(new
                    {
                        posRefId
                    })
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .GetAsync()
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Refund(string posRefId, int refundAmountCents, bool suppressMerchantPassword,
            string headerPosName, string headerPosVersion)
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
                    .PostJsonAsync(refundRequest)
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Refund(string posRefId, string headerPosName, string headerPosVersion)
        {
            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("refund")
                    .SetQueryParams(new
                    {
                        posRefId
                    })
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .GetAsync()
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage SettlementEnquiry(string posRefId, string headerPosName,
            string headerPosVersion)
        {
            var settlementEnquiry = new SettlementEnquiryRequest()
            {
                PosRefId = posRefId,
            };

            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("settlement_enquiry")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .PostJsonAsync(settlementEnquiry)
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }

        public static HttpResponseMessage Ping(string headerPosName, string headerPosVersion)
        {
            try
            {
                var response = "http://localhost:8282/v1"
                    .AppendPathSegment("ping")
                    .WithHeader(HeaderPosName, headerPosName)
                    .WithHeader(HeaderPosVersion, headerPosVersion)
                    .GetAsync()
                    .Result;

                return response;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is FlurlHttpException)
                        return new HttpResponseMessage(HttpStatusCode.BadRequest);

                    if (ex is FlurlHttpTimeoutException)
                        return new HttpResponseMessage(HttpStatusCode.RequestTimeout);
                }

                throw;
            }
        }
    }
}
