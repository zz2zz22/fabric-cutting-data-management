using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloth_cutting_data_report
{
    [Serializable()]
    public class DetailInformation
    {
        public string DateReceive { get; set; }
        public string MainCode { get; set; }
        public string DetailCode { get; set; }
        public string Quantity { get; set; }
        public double Weight { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
