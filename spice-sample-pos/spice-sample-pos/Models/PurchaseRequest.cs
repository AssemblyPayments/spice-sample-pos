﻿using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class PurchaseRequest
    {
        [JsonProperty(PropertyName = "posRefId")]
        public string PosRefId { get; set; }

        [JsonProperty(PropertyName = "purchaseAmount")]
        public int PurchaseAmountCents { get; set; }

        [JsonProperty(PropertyName = "tipAmount")]
        public int TipAmountCents { get; set; }

        [JsonProperty(PropertyName = "cashoutAmount")]
        public int CashOutAmountCents { get; set; }

        [JsonProperty(PropertyName = "promptForCashout")]
        public bool PromptForCashout { get; set; }

        [JsonProperty(PropertyName = "surchargeAmount")]
        public int SurchargeAmountCents { get; set; }
    }
}
