using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactRemovalTest : TestBase
    {

        [Test]
        public void СontactCreationTests()
        {
            app.Contacts.Remove(1);
            app.Auth.Logout();
        }
    }
}
