using SpecflowTestAutomation.HelperClasses;
using SpecflowTestAutomation.Utilities1;
using TechTalk.SpecFlow;

namespace SpecflowTestAutomation
{
    [Binding]
    public sealed class StepDefinitions
    {
        private HelperClass helperClass = new HelperClass();
        private Utilities utilities = new Utilities();

        [Given(@"I am on the google homepage")]
        public void GivenIAmOnTheGoogleHomepage()
        {
            helperClass.NavigateToURL("http://www.google.com");
            ScenarioContext.Current["WebPageTitle"] = helperClass.GetPageTitle();
        }

        [When(@"I search for webdriver")]
        public void WhenISearchForWebdriver()
        {
            helperClass.SearchFor("webdriver");
        }

        [Then(@"the page title is as expected")]
        public void ThenThePageTitleIsAsExpected()
        {
            utilities.WaitForWebPageTitleToChangeFromOriginal((string)(ScenarioContext.Current["WebPageTitle"]));
            helperClass.CheckPageTitle();
        }



    }
}
