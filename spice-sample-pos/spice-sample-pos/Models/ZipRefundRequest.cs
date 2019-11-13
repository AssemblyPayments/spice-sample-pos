using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class ZipRefundRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "refundAmount")]
        public int RefundAmountCents { get; set; }

        [JsonProperty(PropertyName = "originalReceiptNumber")]
        public string ReceiptNumber { get; set; }
    }
}
