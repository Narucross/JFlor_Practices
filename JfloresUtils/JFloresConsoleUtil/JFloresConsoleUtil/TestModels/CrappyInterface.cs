using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFloresConsoleUtil.JFloresCMenuSystem;
using JFloresConsoleUtil.JFloresCReader;

namespace JFloresConsoleUtil.TestModels
{
    public class CrappyInterface : IBasicMenu
    {
        public void AskForAString()
        {
            "Please enter any string to reprint".P("Welcome to Ask for a string");
            var s = Ju.GetNonNullOrEmptyString();
            s.P("This is the results of the ask for string method:", "||And now this methods done", JuPrintTypes.SingleLines);
        }

        public void AskForInteger()
        {
            "Please enter an integer".P("Welcome to Ask for an Integer", "And now this method(Ask for integer) is done.");
            var i = Ju.GetInt32();
            i.P("You have selected the Integer:", "Closing the ask for integer method", JuPrintTypes.BulletinMode);
        }

        public void Multiplication()
        {
            "Enter the first Number ".P("Welcome you have selected Multiplication");
            var m1 = Ju.GetInt32();
            "Enter the Second Number".P();
            var m2 = Ju.GetInt32();
            var mx = Math.BigMul(m1, m2);
            mx.P(String.Format("This is the result of {0} multiplied by {1}", m1, m2), "Closing the multiplication Method");
        }

        public void StoreNames()
        {
            var stringList = new List<string>(5);
            for (var i = 0; i < 5; i++)
            {
                var s = String.Format("Please enter a name, need {0} more left", (5 - i));
                s.P();
                s = Ju.GetNonNullOrEmptyString();
                stringList.Add(s.ToString());
                stringList.P("Currently In the list", printType: JuPrintTypes.BulletinMode);
                printBorderBreak();
            }
            printBorderBreak();
            stringList.P("Finished List", "Ending 5 choices", JuPrintTypes.BulletinMode);
            printBorderBreak();
        }

        private void printBorderBreak()
        {
            string x = "-";
            for (int i = 0; i < 5; i++)
            {
                x += x;
            }
            x.P();
        }

        public CrappyInterface()
        {
            _MyItems = new MenuItem[]
            {
                new MenuItem("Ask for string", AskForAString),
                new MenuItem("Ask for integer",AskForInteger),
                new MenuItem("Do Multiplication",Multiplication), 
                new MenuItem("Store 5 names",StoreNames), 
            };
        }

        #region implemented members

        // ReSharper disable once InconsistentNaming
        private MenuItem[] _MyItems { get; set; }

        public MenuItem[] MyItems()
        {
            return _MyItems;
        }

        public virtual string MenuName()
        {
            return "Test Menu 1";
        }

        public string MenuDescription()
        {
            return "This is a crappy interface...";
        }
        #endregion

    }//end of class
}//end of namespace