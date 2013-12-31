using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangeListeners.Data.Models
{
    public class Person : Bean
    {

        public Person(string FirstName1, string LastName1, byte Age1, int SSN1, string StreetAddress1, string City1, State_USA State1)
        {
            // TODO: Complete member initialization
            this.FirstName = FirstName1;
            this.LastName = LastName1;
            this.Age = Age1;
            this.SSN = SSN1;
            this.StreetAddress = StreetAddress1;
            this.City = City1;
            this.State = State1;
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public byte Age { get; set; }
        public int SSN { get; set; }

        public String StreetAddress { get; set; }
        public String City { get; set; }

        public State_USA State { get; set; }


        private static Random randy = new Random();
        public static Person generateRandomPerson()
        {
            //int seed = 10196;
            string FirstName = RandomCharacters(ref randy);
            string LastName = RandomCharacters( ref randy);

            byte Age = 21;
            Age = randomByte();
            if (Age == 21)
            {
                //wasnt random
            }
            string StreetAddress = RandomCharacters(ref  randy);
            int SSN = randy.Next(99999999);
            string City = "Riverside";
            State_USA State = State_USA.Alabama;

            Person p = new Person(FirstName, LastName, Age, SSN, StreetAddress, City, State);

            return p;
        }

        private static byte randomByte()
        {
            byte[] byter = new byte[1];
            byter[0] = 0;
            (new Random()).NextBytes(byter);
            return byter[0];
        }

        private static string RandomCharacters(ref Random randy)
        {
            StreamReader reader = new StreamReader("G:\\Z_Projects\\GitHub\\JFlor_Practices\\Cap_Fall_prc\\PropertyChangeListeners\\PropertyChangeListeners\\Data\\DataSets\\TextFile1.txt");
            String returnValue ="";
            int num = randy.Next(1,10195);
            for(int i=0; i<=num && !reader.EndOfStream;i++){
                returnValue = reader.ReadLine();                
            }
            return returnValue;
        }

    }//end of person
}//end of namespace