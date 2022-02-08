using NUnit.Framework;
using Selenium.utilities;

namespace Selenium.test
{
    [SetUpFixture]
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.InitializeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Close();
        }
    }
}