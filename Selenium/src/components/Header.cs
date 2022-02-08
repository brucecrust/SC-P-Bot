using System;
using OpenQA.Selenium;

namespace Selenium.components
{
    public class Header : BaseComponent
    {
        public Header() : base(By.Id("header"))
        {}
    }
}