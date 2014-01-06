using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMenus.BindingPractice
{
    /// <summary>
    /// Class representing a single movie reivew
    /// </summary>
    public class Review
    {
        /// <summary>
        /// THe name of the critic who provided the reivew
        /// </summary>
        public string Critic { get; set; }
        /// <summary>
        /// A snippet of the critic's full review
        /// </summary>
        public string ReviewSnippet { get; set; }
        /// <summary>
        /// Letter grade representing the review. A-F
        /// </summary>
        public string LetterGrade { get; set; }
    }
}
