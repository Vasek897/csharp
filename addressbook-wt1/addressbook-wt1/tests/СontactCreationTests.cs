using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
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
