﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
namespace WebAddressbookTests
{
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("ZZZ");
            newData.Header = "TTT";
            newData.Footer = "YYY";

            app.Groups.Modify(1, newData);          
        }
    }
}
