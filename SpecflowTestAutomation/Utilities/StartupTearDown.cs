using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowTestAutomation
{
    [Binding]
    public class Class1
    {
        private static IWebDriver driver;

        [Before]
        public static void StartWebdriver()
        {
            System.Console.WriteLine("Test running");
            //24/12/15 - FFdriver doesnt work - says 'cannot find the file specified' - defect?
            //IWebDriver driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();            
            FeatureContext.Current.Add("CurrentDriver", driver);
        }

        [After]
        public static void StopWebdriver()
        {
            // Comment out the line below to keep the browser instance open when tests are complete
            driver.Quit();
        }

    }
}
