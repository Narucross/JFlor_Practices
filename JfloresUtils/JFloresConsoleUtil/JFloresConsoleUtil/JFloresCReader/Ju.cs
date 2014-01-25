using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFloresConsoleUtil.JFloresCReader
{
    /// <summary>
    /// Will Contains the infamous PrintEnumberable method
    /// </summary>
    public static class Ju
    {
        /// <summary>
        /// All purpose print method event takes in Arrays as Ienumerables
        /// </summary>
        /// <param name="objectO">The object to print</param>
        /// <param name="preText">The text to place before the printing of the object</param>
        /// <param name="postText">The text that is rendered after the printing of the object</param>
        /// <param name="printType">See inner descriptions for printing types and functions</param>
        public static void P(this object objectO, string preText = "", string postText = "", JuPrintTypes printType = JuPrintTypes.AllNewLines)
        {
            if (objectO is IEnumerable)
            {
                PrintEnumberable(objectO as IEnumerable, preText, postText, printType);
            }
            else
            {
                PrintStrindDependentOnPrintType(objectO.ToString(), preText, postText, printType);
            }
        }

        /// <summary>
        /// Prints an Ienumerable, 
        /// </summary>
        private static void PrintEnumberable(IEnumerable objEnumerable, string preText = "", string postText = "",
            JuPrintTypes printType = JuPrintTypes.AllNewLines)
        {
            var builder = new StringBuilder();
            switch (printType)
            {
                case JuPrintTypes.AllNewLines:
                    builder.Append(preText);
                    builder.Append("\n");
                    foreach (var currentObject in objEnumerable)
                    {
                        builder.Append(String.Format("{0}\n", currentObject.ToString()));
                    }
                    builder.Append(preText);
                    builder.Append("\n");
                    break;
                case JuPrintTypes.SingleLines:
                    builder.Append(preText);
                    builder.Append("{\t");
                    foreach (var currentObject in objEnumerable)
                    {
                        builder.Append(currentObject.ToString());
                        builder.Append(", ");
                    }
                    builder.Append("}\t");
                    builder.Append(postText);
                    builder.Append("\n");
                    break;
                case JuPrintTypes.BulletinMode:
                    builder.Append(preText);
                    builder.Append("\n{");
                    foreach (var currentObject in objEnumerable)
                    {
                        builder.Append("\n\t");
                        builder.Append(currentObject.ToString());
                    }
                    builder.Append("\n}");
                    break;
            }
            Console.WriteLine(builder);//Print line right here 
        }

        private static void PrintStrindDependentOnPrintType(string objectToString, string preText, string postText, JuPrintTypes printTypes)
        {
            var returnValue = String.Empty;
            switch (printTypes)
            {
                case JuPrintTypes.AllNewLines:
                    returnValue = String.Format("{1}\n{0}\n{2}", objectToString, preText, postText);
                    break;
                case JuPrintTypes.SingleLines:
                    returnValue = String.Format("{1} :  {0} ; {2}", objectToString, preText, postText);
                    break;
                case JuPrintTypes.BulletinMode:
                    returnValue = String.Format("{1}\n\t{0}\n{2}", objectToString, preText, postText);
                    break;
            }
            Console.WriteLine(returnValue);
        }

        #region get Methods

        /// <summary>
        /// Gets a non null or empty String
        /// </summary>
        public static string GetNonNullOrEmptyString()
        {
            var complete = false;
            var value = String.Empty;
            while (!complete)
            {
                value = Console.ReadLine();
                complete = value != null && !String.Empty.Equals(value);
            }
            return value;
        }

        /// <summary>
        /// Returns a non-null integer, infinite range
        /// </summary>
        public static int GetInt32()
        {
            var complete = false;
            var value = 0;
            while (!complete)
            {
                var currentLine = Console.ReadLine();
                complete = Int32.TryParse(currentLine, out value);
            }
            return value;
        }

        /// <summary>
        /// Gets an integer within the selected range, 
        /// It is not important which is the upper or lower bound even if they are different
        /// </summary>
        /// <param name="bound1">Defaults as the upper maxium number for an integer</param>
        /// <param name="bound2">Defaults as the lower minium number for an integer</param>
        /// <returns></returns>
        public static int GetInt32InRange(int bound1 = Int32.MaxValue, int bound2 = Int32.MinValue)
        {
            var value = Math.Max(bound1, bound2);
            bound2 = Math.Min(bound1, bound2);
            bound1 = value;
            var complete = false;
            while (!complete)// Same as regular GetInt32
            {
                var currentLine = Console.ReadLine();
                complete = Int32.TryParse(currentLine, out value);
                if (complete)//survives parsing...
                {
                    complete = value >= bound1 && value <= bound2;
                }
            }
            return value;
        }

        #endregion
    }
}//end of class