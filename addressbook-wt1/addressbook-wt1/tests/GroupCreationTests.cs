﻿using System;
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
            app.Auth.Logout();
        }
        public void EmptyGroupCreationTest()
        {
            app.Navigator.GoToGroupsPage();

            GroupData group = new GroupData(" ");
            group.Header = " ";
            group.Footer = " ";

            app.Groups.Create(group);
            app.Auth.Logout();
        }

    }
}