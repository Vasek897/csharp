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
    public class ContactHelper : HelperBase
    {       
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }       
        public ContactHelper FillContactCReation(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToContactsPage();
            FillContactCReation(contact);
            SubmitContactCreation();
            return this;
        }


        public ContactHelper SelectContact(int index)

        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.CssSelector("*[value='Delete']")).Click();
            //driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper Remove(int p)
        {
            manager.Navigator.GoToHomePage();

            SelectContact(p);
            RemoveContact();
            return this;
        }
        public ContactHelper Modify(int p, ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            SelectContact(p);
            InitGroupModification();
            FillContactCReation(newData);
            SubmitContactModification();
            return this;
        }

        private ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        private ContactHelper InitGroupModification()
        {
            driver.FindElement(By.CssSelector("*[title='Edit']")).Click();
            return this;
        }
    }
}
