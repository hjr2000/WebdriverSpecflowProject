using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SpecflowTestAutomation.PageObjects1;
using NUnit.Framework;

namespace SpecflowTestAutomation.HelperClasses
{
    class HelperClass
    {
        IWebDriver driver = (IWebDriver)FeatureContext.Current["CurrentDriver"];
        PageObjects pageObjects = new PageObjects();

        public void NavigateToURL(string URL)
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        internal void SearchFor(string searchTerm)
        {
            pageObjects.PopulateSearchTextbox(searchTerm);
            pageObjects.ClickSearchButton();
        }

        internal string GetPageTitle()
        {
            return pageObjects.GetPageTitle();
        }

        public void CheckPageTitle()
        {
            Assert.AreEqual("webdriver - Google Search", GetPageTitle());
        }
    }
}
