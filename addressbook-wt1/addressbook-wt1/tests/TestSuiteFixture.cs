﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
      
        [OneTimeSetUp]
        public void InitApplicationManager()
        {
            ApplicationManager app= ApplicationManager.GetInstance();   
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToHomePage();
        }

        
    }
}
