using Newtonsoft.Json;

namespace spice_sample_pos.Models.Requests
{
    public class PurchaseRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "purchaseAmount")]
        public int PurchaseAmountCents { get; set; }

        [JsonProperty(PropertyName = "tipAmount")]
        public int TipAmountCents { get; set; }

        [JsonProperty(PropertyName = "cashOutAmount")]
        public int CashOutAmountCents { get; set; }

        [JsonProperty(PropertyName = "promptForCashout")]
        public bool PromptForCashout { get; set; }

        [JsonProperty(PropertyName = "surchageAmount")]
        public int SurchageAmountCents { get; set; }
    }
}
