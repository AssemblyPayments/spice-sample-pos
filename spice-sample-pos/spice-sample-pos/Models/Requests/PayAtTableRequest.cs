using Newtonsoft.Json;

namespace spice_sample_pos.Models.Requests
{
    public class PayAtTableRequest
    {
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        [JsonProperty(PropertyName = "tableId")]
        public string TableId { get; set; }

        [JsonProperty(PropertyName = "outstandingAmount")]
        public int OutstandingAmount { get; set; }

        [JsonProperty(PropertyName = "totalAmount")]
        public int TotalAmount { get; set; }

        [JsonProperty(PropertyName = "billId")]
        public string BillId { get; set; }
    }
}
