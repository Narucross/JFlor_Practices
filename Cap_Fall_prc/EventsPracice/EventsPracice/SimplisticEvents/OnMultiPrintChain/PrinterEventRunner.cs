using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPracice.SimplisticEvents.OnMultiPrintChain
{
    class PrinterEventRunner
    {
        public static void Start(string[] args)
        {
            PrinterOfNotifications printingClass = new PrinterOfNotifications();
            printingClass.OnPrint += printMessage1;
            printingClass.OnPrint += printMessage2;
            printingClass.forTillInvoke(4);
        }

        static void printMessage1(object sender, PrinterEventArgs e) {
            Console.WriteLine("Coming to you live from the first Message invoker :: {0}.) {1}",e.numberWhenAdded, e.message);
        }
        static void printMessage2(object sender, PrinterEventArgs e) {
            Console.WriteLine("Second phase :: {0}.){1}", e.numberWhenAdded, e.message);
        }
    }
}
