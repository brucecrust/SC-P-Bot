using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.screens;
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
            
            Home home = new Home();
            home.WaitForDisplay();
            home.VerifyHeader();
        }
    }
}