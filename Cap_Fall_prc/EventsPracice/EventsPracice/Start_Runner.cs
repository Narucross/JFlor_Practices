using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsPracice.SimplisticEvents.OnMultiPrintChain;
namespace EventsPracice
{
    class Start_Runner
    {
        static void Main(string[] args)
        {
            PrinterEventRunner.Start(args);
            Console.ReadLine();
            
        }
    }
}
