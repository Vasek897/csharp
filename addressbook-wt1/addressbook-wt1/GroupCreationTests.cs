using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigator.OpenHomePage();
            loginHelper.Login (new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(new GroupData("RoR","ddd","TTT"));
            SubmitGroupCreation();
            Logout();
        }
       
    }
}
