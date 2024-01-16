using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        public string baseURL;
        public NavigationHelper(ApplicationManager manager,string baseURL) :base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/adressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;      
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
