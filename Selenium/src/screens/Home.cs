using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Selenium.components;
using Selenium.utilities;

namespace Selenium.screens
{
    public class Home
    {
        private Header header = new Header();
        
        public Home()
        {}

        public void VerifyHeader()
        {
            Assert.True(header.element.Displayed);
        }
        
        public void WaitForDisplay()
        {
            header.WaitForElement();
        }
    }
}