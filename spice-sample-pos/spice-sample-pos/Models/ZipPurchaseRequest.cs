using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class ZipPurchaseRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "purchaseAmount")]
        public int PurchaseAmountCents { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
