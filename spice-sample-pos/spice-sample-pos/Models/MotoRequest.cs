using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class MotoRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "purchaseAmount")]
        public int PurchaseAmountCents { get; set; }

        [JsonProperty(PropertyName = "surchargeAmount")]
        public int SurchargeAmountCents { get; set; }

        [JsonProperty(PropertyName = "suppressMerchantPassword")]
        public bool SuppressMerchantPassword { get; set; }
    }
}