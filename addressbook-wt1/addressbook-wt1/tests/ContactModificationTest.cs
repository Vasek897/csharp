using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace aWebAddressbookTests
{
    public class ContactModificationTest : TestBase
    {

        [Test]
        public void СontactCreationTests()
        {
            ContactData contact = new ContactData("Иван");
            contact.Middlename = "Иванович";
            contact.Lastname = "Иванов";

            app.Contacts.Create(contact);
            app.Auth.Logout();
        }
    }
}
