using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information
{
    public class PersonalInfo
    {
        //public string FirstName { get; set; }

        //public string MiddleName { get; set; }

        //public string LastName { get; set; }

        private string FirstName;
        private string MiddleName;
        private string LastName;

        private int point;
        public PersonalInfo()
        {
            this.point = 10;
        }

        public PersonalInfo(string FirstName, string LastName):this()
        {
            this.FirstName = FirstName;
            //this.MiddleName = MiddleName;
            this.LastName = LastName;
        }

        public PersonalInfo(string FirstName, string MiddleName, string LastName):this(FirstName, LastName)
        {
            //this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            //this.LastName = LastName;
        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }

        public string GetReverseName()
        {
            //string fullName = LastName + " " + MiddleName + " " + FirstName;
            //return fullName;

            string reverseName = "";
            string fullName = GetFullName();

            for(int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }

            return reverseName;
        }
    }
}
