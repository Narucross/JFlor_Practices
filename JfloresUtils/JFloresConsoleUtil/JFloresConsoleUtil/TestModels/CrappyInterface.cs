using System;
using System.Collections.Generic;
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
            var s = Ju.GetNonNullOrEmptyString();
            s.P("This is the results of the ask for string method:", "And now this methods done");
        }

        public void AskForInteger()
        {
            "Please enter an integer".P(postText: "And now this method(Ask for integer) is done.");
            var i = Ju.GetInt32();
            i.P("You have selected the Integer:", "Closing the ask for integer method");
        }

        public void Multiplication()
        {
            var m1 = Ju.GetInt32();
            var m2 = Ju.GetInt32();
            var mx = Math.BigMul(m1, m2);
            mx.P(String.Format("This is the result of {0} multiplied by {1}", m1, m2), "Closing the multiplication Method");
        }

        public CrappyInterface()
        {
            _MyItems = new MenuItem[]
            {
                new MenuItem("Ask for string", AskForAString),
                new MenuItem("Ask for integer",AskForInteger),
                new MenuItem("Do Multiplication",Multiplication), 

            };
        }

        #region implemented members

        // ReSharper disable once InconsistentNaming
        private MenuItem[] _MyItems { get; set; }

        public MenuItem[] MyItems()
        {
            return _MyItems;
        }

        public string MenuName()
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