using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPracice.SimplisticEvents.OnMultiPrintChain
{
    public class PrinterOfNotifications
    {
        public event EventHandler<PrinterEventArgs> OnPrint;

        /// <summary>
        /// Invokes the OnPrint Event
        /// </summary>
        protected void PrintEventInvoker(PrinterEventArgs e)
        {
            EventHandler<PrinterEventArgs> saftyNetHandler = OnPrint;
            if (saftyNetHandler != null)
            {
                saftyNetHandler(this, e);
            }
        }

        public void forTillInvoke(int iterations) {
            PrinterEventArgs newArgs = new PrinterEventArgs();
            newArgs.message = String.Format("It took : {0} to complete",iterations);
            newArgs.numberWhenAdded = iterations;
            PrintEventInvoker(newArgs);
        }

    }
}
