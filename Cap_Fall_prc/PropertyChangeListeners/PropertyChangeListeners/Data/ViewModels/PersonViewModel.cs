using PropertyChangeListeners.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangeListeners.Data.ViewModels
{
    public abstract class PersonViewModel
    {
        /// <summary>
        /// You implement this method in order to save the fields you want, I would use reflection for this but fu
        /// </summary>
        /// <param name="p"> Da person you want to copy</param>
        abstract protected void CopyPerson(Person p);

        public PersonViewModel(Person p) {
            CopyPerson(p);
        }
    }//end of class
}//end of namespace