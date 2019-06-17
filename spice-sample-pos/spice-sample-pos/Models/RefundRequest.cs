using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class RefundRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "refundAmount")]
        public int RefundAmountCents { get; set; }

        [JsonProperty(PropertyName = "suppressMerchantPassword")]
        public bool SuppressMerchantPassword { get; set; }
    }
}
