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
            
            app.Navigator.GoToGroupsPage();

            GroupData group = new GroupData("RoR");
            group.Header = "DDD";
            group.Footer = "FFF";

            app.Groups.Create(group);
            GroupHelper.FillGroupForm(group);
            app.Auth.Logout();
        }
        public void EmptyGroupCreationTest()
        {
            GroupHelper.FillGroupForm(new GroupData("", "", ""));

            app.Navigator.GoToGroupsPage();
            app.Auth.Logout();
        }

    }
}
