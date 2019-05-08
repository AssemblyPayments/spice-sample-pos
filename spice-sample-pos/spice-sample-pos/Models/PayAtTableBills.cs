using System;

namespace spice_sample_pos.Models
{
    [Serializable]
    public class PayAtTableBills
    {
        public string BillId;
        public string TableId;
        public string OperatorId;
        public string Label;
        public int TotalAmount = 0;
        public int OutstandingAmount = 0;
        public int TippedAmount = 0;
        public bool Locked = false;
    }
}
