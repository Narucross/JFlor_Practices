using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFloresConsoleUtil.JFloresCMenuSystem
{
    /// <summary>
    /// The base class, where you place a datamodel and give each option a running void method to do its function...
    /// </summary>
    public interface IBasicMenu
    {
        // List of Menu Items por favor :D??
        //Should this be an interface?
        MenuItem[] MyItems();

        /// <summary>
        /// The name of the menu, so that the main menu can tell you what it is...
        /// </summary>
        /// <returns></returns>
        String MenuName();

        /// <summary>
        /// An optional property, to describe what the menu is suppose to do.
        /// </summary>
        /// <returns></returns>
        String MenuDescription();
    }//end of Class
}//end of namespace