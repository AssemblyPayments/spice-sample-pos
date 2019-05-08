using Newtonsoft.Json;

namespace spice_sample_pos.Models.Requests
{
    public class SettlementEnquiryRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }
    }
}
