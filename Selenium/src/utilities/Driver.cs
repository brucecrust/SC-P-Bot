using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.utilities
{
    public static class Driver
    {
        public static IWebDriver driver;
        
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }
    }
}