using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFloresConsoleUtil.JFloresCMenuSystem;

namespace JFloresConsoleUtil.JFloresCMenuSystem
{
    /// <summary>
    /// Add Menus to this constructor to get a console app working immediately
    /// </summary>
    public class MenuMaster
    {
        private List<IBasicMenu> Menus { get; set; }
        private IBasicMenu CurrentMenu { get; set; }
        private StarterMenu MyStarterMenu { get; set; }

        public MenuMaster(ICollection<IBasicMenu> toConstructMenus)
        {
            MyStarterMenu = new StarterMenu();
            CurrentMenu = MyStarterMenu;
            Menus = new List<IBasicMenu>(toConstructMenus.Count + 1);
            Menus.Add(MyStarterMenu);
            Menus.AddRange(toConstructMenus);
            /*
             * Things to do:
             * List out all the menues to be decided by numbers, 
             * Next list out all options and call the methods, format awesomely
             */
        }

        private class StarterMenu : IBasicMenu
        {
            public StarterMenu()
            {
                MyMenuList = new List<MenuItem>();
            }

            private List<MenuItem> MyMenuList { get; set; }

            public MenuItem[] MyItems()
            {
                throw new NotImplementedException();
            }
        }
    }//end of Class
}//end of namespace