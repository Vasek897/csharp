using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData
    {
        public string firstname;
        public string middlename;
        public string lastname;
        public ContactData(string firstname)
        {
            this.firstname = firstname;
           
        }



        public ContactData(string firstname, string middlename, string lastname)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
        }
        public string Firstname
        {
            get
            { return firstname; }
            set
            { firstname = value; }
        }
        public string Middlename
        {
            get
            { return middlename; }
            set { middlename = value; }
        }
        public string Lastname
        {
            get
            { return lastname; }
            set
            { lastname = value; }
        }

    }
}