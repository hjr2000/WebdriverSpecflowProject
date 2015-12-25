using SpecflowTestAutomation.PageObjects1;
using System;
using System.Threading;

namespace SpecflowTestAutomation.Utilities1
{
    class Utilities
    {
        PageObjects pageObjects = new PageObjects();

        public void WaitForWebPageTitleToChangeFromOriginal(string originalPageTitle)
        {
            bool PageChanged = false;
            for (int i = 1; i < 20; i++)
            {
                string CurrentWebPageTitle = pageObjects.GetPageTitle();
                if (!CurrentWebPageTitle.Equals(originalPageTitle))
                {
                    PageChanged = true;
                    break;
                }
                Thread.Sleep(250);
            }
            if (!PageChanged)
                throw new Exception("The title of the web page is not changing");
        }

    }
}
