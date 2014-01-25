using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFloresConsoleUtil.JFloresCMenuSystem
{
    /// <summary>
    /// Contains the name of the option to be called, as well as the associated action to do.
    /// </summary>
    public class MenuItem
    {
        public MenuItem(string name, Action action)
        {
            OptionName = name;
            MyAction = action;

        }


        public string OptionName { get; set; }

        public Action MyAction { get; set; }

        public override string ToString()
        {
            return OptionName;
        }
    }//end of Class
}//end of namespace