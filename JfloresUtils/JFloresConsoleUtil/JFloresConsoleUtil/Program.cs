using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFloresConsoleUtil.JFloresCMenuSystem;
using JFloresConsoleUtil.JFloresCReader;
using JFloresConsoleUtil.TestModels;

namespace JFloresConsoleUtil
{
    public class Program
    {
        static void Main(string[] args)
        {
            var master = new MenuMaster(new IBasicMenu[] { new CrappyInterface(), new CrappyInterface2(), });
            while (master.Run())
            {
            }
            "Program done. Press enter to exit".P();
            Console.ReadLine();
        }
    }
}
