using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class PurchaseRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "purchaseAmount")]
        public int PurchaseAmount { get; set; }

        [JsonProperty(PropertyName = "tipAmount")]
        public int TipAmount { get; set; }

        [JsonProperty(PropertyName = "cashOutAmount")]
        public int CashOutAmount { get; set; }

        [JsonProperty(PropertyName = "promptForCashout")]
        public bool PromptForCashout { get; set; }

        [JsonProperty(PropertyName = "surchageAmount")]
        public int SurchageAmount { get; set; }
    }
}
