using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            app.Auth.Logout();

            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(new AccountData("admin", "secret"));

            Assert.IsTrue(app.Auth.IsLoggedIn());
        }
    
   
    
        [Test]
        public void LoginWithInvalidCredentials()
        {
            app.Auth.Logout();

            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(new AccountData("admin", "secret"));

            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
}
 }
