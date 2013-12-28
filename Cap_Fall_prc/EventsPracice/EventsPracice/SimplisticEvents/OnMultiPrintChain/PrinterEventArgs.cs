using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPracice.SimplisticEvents.OnMultiPrintChain
{
    public class PrinterEventArgs : EventArgs
    {
        public string message { get; set; }
        public int numberWhenAdded { get; set; }
    }
}
