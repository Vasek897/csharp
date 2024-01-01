using OpenQA.Selenium.DevTools.V118.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class GroupData
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }
        public string Name
        {
            get
            { return name; }
            set
            {  name = value; }
        }
        public string Header
        {
            get
            { return header; }
            set { header = value; }
        }
        public string Footer
        { 
            get 
            { return footer; }
            set 
            { footer = value; }
        }
        
    }
}
