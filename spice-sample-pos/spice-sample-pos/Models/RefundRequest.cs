using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class RefundRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "amountCents")]
        public int RefundAmountCents { get; set; }
    }
}
