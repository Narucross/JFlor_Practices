using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFloresConsoleUtil.JFloresCReader
{
    /// <summary>
    /// This determines the printing behavior of the P method and how to deal with line spacing.
    /// </summary>
    public enum JuPrintTypes : byte
    {
        /// <summary>
        /// Creates a new line for every entry if a list/array is passed into the Pmethod.
        /// </summary>
        AllNewLines,
        /// <summary>
        /// Regardless of number of enteries it will try to keep them all on one line.
        /// </summary>
        SingleLines,
        /// <summary>
        /// "Like AllNewLines, however it also indents all entries in the list/array."
        /// </summary>
        BulletinMode
    }
}
