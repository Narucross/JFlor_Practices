using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JFloresConsoleUtil.JFloresCMenuSystem;
using JFloresConsoleUtil.JFloresCReader;

namespace JFloresConsoleUtil.JFloresCMenuSystem
{
    /// <summary>
    /// Add Menus to this constructor to get a console app working immediately
    /// </summary>
    public class MenuMaster
    {
        private List<IBasicMenu> Menus { get; set; }
        private IBasicMenu CurrentMenu { get; set; }
        private bool HomePage { get; set; }
        private bool ManyMenus { get; set; }
        private ConsoleColor[] ColorCylces { get; set; }
        private int CurrentColor { get; set; }

        //Constructor
        public MenuMaster(IEnumerable<IBasicMenu> myMenus)
        {
            Menus = new List<IBasicMenu>(myMenus);
            ManyMenus = Menus.Count > 1;
            CurrentMenu = Menus[0];
            HomePage = true;
            ColorCylces = new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.DarkYellow, ConsoleColor.Cyan, ConsoleColor.DarkMagenta, ConsoleColor.White };
            CurrentColor = 0;
            Console.WriteLine("\n"); //Gets the console on the screen.
            Console.Clear();

        }

        // THis should be encased in a while loop
        public bool Run()
        {
            var shouldContinue = true;
            if (ManyMenus)
            {
                if (HomePage)
                {
                    SelectFromBelow();
                    for (var i = 1; i <= Menus.Count; i++)
                    {
                        String.Format("{0}.) {1}", i, Menus[i - 1]).P();//Maybe bullitin?						
                    }
                    "0.) Exit Program".P();
                    var selection = Ju.GetInt32InRange(0, Menus.Count);
                    if (selection <= Menus.Count && selection >= 1)
                    {
                        CurrentMenu = Menus[selection - 1];
                        HomePage = false;
                    }
                    else
                    {
                        shouldContinue = selection != 0;
                    }
                }
                else // if we are not on the homepage but a lesser page
                {
                    if (CurrentMenu != null)
                    {
                        //Print out options and select like before
                        var offSet = GetOptionSelectionFromMenu(CurrentMenu, "0.) Return to Main Menu");
                        HomePage = offSet == 0;
                        if (HomePage) return true;
                        offSet--;
                        CurrentMenu.MyItems()[offSet].MyAction();
                    }
                    else
                    { //Error abort
                        Console.ForegroundColor = (ConsoleColor.Red);
                        Console.WriteLine("We encountered a Null pointer for the Current Menu");
                        return false;
                    }
                }
            }
            else
            { // No need for a Homemenu stay on current or the first or default
                //Print options and make sure that they are in range
                var offSet = GetOptionSelectionFromMenu(CurrentMenu, "0.) Exit The Program");
                shouldContinue = offSet != 0;
                if (!shouldContinue) return false;
                offSet--;
                CurrentMenu.MyItems()[offSet].MyAction();
            }
            CycleColor();
            return shouldContinue;
        }

        private int GetOptionSelectionFromMenu(IBasicMenu c, string zerothOption)
        {
            var options = c.MyItems();
            var offSet = 0;
            SelectFromBelow();
            for (var i = 1; i <= options.Length; i++)
            {
                offSet = i - 1;
                String.Format("{0}.) {1}", i, options[offSet]).P();
            }
            zerothOption.P();
            offSet = Ju.GetInt32InRange(0, options.Length);
            return offSet;
        }

        private void SelectFromBelow()
        {
            "\n\nSelect an option from the Following\n".P();
        }

        private void CycleColor()
        {
            "\n\n".P();
            CurrentColor++;
            if (CurrentColor >= ColorCylces.Length)
            {
                CurrentColor = 0;
            }
            Console.ForegroundColor = ColorCylces[CurrentColor];
        }
    }//end of Class
}//end of namespace