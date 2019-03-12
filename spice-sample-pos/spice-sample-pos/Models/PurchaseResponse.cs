using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace spice_sample_pos.Models
{
    public class PurchaseResponse
    {
        [JsonProperty(PropertyName = "Response")]
        public PurchaseBodyResponse Response { get; set; }
    }

    public class PurchaseBodyResponse
    {
        [JsonProperty(PropertyName = "customer_receipt")]
        public string CustomerReceipt { get; set; }
    }
}
