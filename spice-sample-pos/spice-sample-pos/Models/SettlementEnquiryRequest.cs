using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class SettlementEqnuiryRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }
    }
}
