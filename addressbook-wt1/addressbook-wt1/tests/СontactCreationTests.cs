﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Иван");
            contact.Middlename = "Иванович";
            contact.Lastname = "Иванов";

            app.Contacts.Create(contact);
            
        }
        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData(" ");
            contact.Middlename = " ";
            contact.Lastname = " ";

            app.Contacts.Create(contact);
        }
    }          
}
