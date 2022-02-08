using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.utilities;

namespace Selenium.components
{
    public class BaseComponent
    {
        // Member Variables --------------------------------------------------------------------------------------------
        
        public By matcher;
        public IWebElement element;

        // Constructor -------------------------------------------------------------------------------------------------

        public BaseComponent(By matcher)
        {
            this.matcher = matcher;
        }
        
        // Action Methods ----------------------------------------------------------------------------------------------

        public void Click()
        {
            
        }
        
        // Utility Methods ---------------------------------------------------------------------------------------------

        public void WaitForElement()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            element = wait.Until(e => e.FindElement(matcher));
        }
    }
}