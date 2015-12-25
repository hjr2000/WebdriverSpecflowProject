using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecflowTestAutomation.PageObjects1
{
    public class PageObjects : PageBase
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        private IWebElement SearchTextbox;

        [FindsBy(How = How.ClassName, Using = "lsb")]
        private IWebElement SearchButton;        

        public void PopulateSearchTextbox(string searchTerm)
        {

            SearchTextbox.Clear();
            SearchTextbox.SendKeys(searchTerm);
        }

        public void ClickSearchButton()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("lsb")));

            SearchButton.Click();
        }

        public string GetPageTitle()
        {

            return driver.Title;
        }

    }
}
