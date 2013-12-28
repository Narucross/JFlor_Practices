using PropertyChangeListeners.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangeListeners.Data.ViewModels
{
    public class PersonPublicKnowledgeViewModel : PersonViewModel
    {
        public PersonPublicKnowledgeViewModel(Person p) :base(p)
        {
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public byte Age { get; set; }

        public String StreetAddress { get; set; }
        public String City { get; set; }

        public State_USA State { get; set; }

        protected override void CopyPerson(Models.Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Age = p.Age;
            StreetAddress = p.StreetAddress;
            City = p.City;
            State = p.State;
        }
    }
}
