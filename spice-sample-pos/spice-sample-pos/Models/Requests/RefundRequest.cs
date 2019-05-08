using Newtonsoft.Json;

namespace spice_sample_pos.Models.Requests
{
    public class RefundRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "refundAmount")]
        public int RefundAmountCents { get; set; }
    }
}
