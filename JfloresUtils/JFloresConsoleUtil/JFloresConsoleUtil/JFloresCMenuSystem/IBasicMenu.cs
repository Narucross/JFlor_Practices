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

    }//end of Class
}//end of namespace