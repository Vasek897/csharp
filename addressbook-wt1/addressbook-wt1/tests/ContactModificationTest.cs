
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace WebAddressbookTests
{
    public class ContactModificationTest : AuthTestBase
    {

        [Test]
        public void ContactModificationTes()
        {
            ContactData contact = new ContactData("Петр");
            contact.Middlename = "Петров";
            contact.Lastname = "Петрович";

            app.Contacts.Modify(1, contact);
        }
    }
}
