using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.test;
using Selenium.utilities;

namespace Selenium
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void Test1()
        {
            Driver.driver.Navigate().GoToUrl("https://scp-wiki.wikidot.com/");
            
            By matcher = By.Id("header");
            IWebElement header = null;
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
            
            wait.Until(e => header = e.FindElement(matcher));

            Assert.True(header.Displayed);
        }
    }
}