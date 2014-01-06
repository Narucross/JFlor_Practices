using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMenus
{
    public class SimpleBean
    {
        public String Name;
        public Boolean IsActive;
        public System.Windows.Input.RoutedUICommand ActivateCommand;

        public SimpleBean()
        {
            Name = "";
            IsActive = true;
            ActivateCommand = System.Windows.Input.ApplicationCommands.Copy;
        }
    }
}
