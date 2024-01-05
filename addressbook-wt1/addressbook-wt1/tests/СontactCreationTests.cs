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
            app.Navigator.GoToContactsPage();
            app.Contacts.FillContactCReation(new ContactData("Иван", "Иванович", "Иванов"));
            app.Contacts.SubmitContactCreation();
            app.Auth.Logout();
        }
    }          
}
