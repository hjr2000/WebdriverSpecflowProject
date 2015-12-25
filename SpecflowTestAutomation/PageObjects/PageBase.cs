using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace SpecflowTestAutomation.PageObjects1
{
    public class PageBase
    {
        public IWebDriver driver = (IWebDriver)FeatureContext.Current["CurrentDriver"];

        public PageBase()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
