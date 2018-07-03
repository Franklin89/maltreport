using System;
using System.Collections.Generic;
using System.Text;

namespace MaltReport.HelloWorld
{

    public class Transaction
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public double Buy { get; set; }
        public double Sell { get; set; }
    }

}
