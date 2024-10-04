using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestCsharp.Tests
{
    public class LoginTest
    {
        // this works fine with Chrome
        [Test]
        public void Test()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://selenium.dev");

            driver.Quit();

        }
    }
}
