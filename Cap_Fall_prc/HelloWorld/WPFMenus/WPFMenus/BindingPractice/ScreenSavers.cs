using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMenus.BindingPractice
{
    /// <summary>
    /// Make-shift representation of a Screen
    /// </summary>
    public class ScreenSavers
    {
        /// <summary>
        /// The Name of the template
        /// </summary>
        public String TemplateName { get; set; }

        /// <summary>
        /// The collection of screens it has to deal with it... It is going to have to be linked to something that provides the screens and subs to it...
        /// </summary>
        public Review[] Screens { get; set; }
    }
}
