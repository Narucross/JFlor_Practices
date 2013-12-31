using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedPane_Excercise_1.ScreenUtils
{
    /// <summary>
    /// Find screens other screen related utility
    /// </summary>
    class ScreenDetector
    {
        public static ScreenBean[] getRandomScreens(short numberOfScreens = 1)
        {
            var beanArray = new ScreenBean[numberOfScreens];
            Random randy = new Random();
            for (int i = 0; i < beanArray.Length; i++)
            {
                beanArray[i] = ScreenBean.NewRandomScreenBean(ref randy, i);
            }
            return beanArray;
        }

    }//end of class

    //==============================================
    //==============================================
}//end of Namespace