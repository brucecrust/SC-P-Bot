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

        // Constructor -------------------------------------------------------------------------------------------------

        BaseComponent(By matcher)
        {
            this.matcher = matcher;
        }
        
        // Action Methods ----------------------------------------------------------------------------------------------

        public void Click()
        {
            
        }
        
        // Utility Methods ---------------------------------------------------------------------------------------------

        private void BuildElement()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
        }
    }
}