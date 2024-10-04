using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

using SeleniumTestCsharp.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestCsharp.Pages
{
    public class Home 
    {
        //Locators
        [FindsBy(How = How.CssSelector, Using = "#small-searchterms")]
        private IWebElement SearchStoreInput;
        [FindsBy(How = How.XPath, Using = "//input[@value='Search']")]
        private IWebElement SearchButton;
        //Actions
        public void isAt()
        {
            Assert.That(Browsers.Title, Is.EqualTo("nopCommerce demo store"));
        }
        public void EnterSearchText(string searchText)
        {
            Assert.That(SearchStoreInput.Displayed, Is.True);
            SearchStoreInput.SendKeys(searchText);
        }
    }
}
