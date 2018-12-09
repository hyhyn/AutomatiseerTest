using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Search_testframework.Framework
{
    public class TopNavigation
    {
        private readonly IWebDriver webDriver;

        public TopNavigation(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void Search(String keywords)
        {
            webDriver.FindElement(By.Id("et_top_search")).Click();
            webDriver.FindElement(By.ClassName("et-search-field")).SendKeys(keywords + Keys.Enter);
        }

        public bool IsEmpty()
        {
            IWebElement element = webDriver.FindElement(By.Id("left-area"));
            if (element.FindElements(By.ClassName("entry")).Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool ContainsKeywords(String keywords)
        {
            //check if the results contain(s) the keyword(s).
            return false;
        }

        //empty example method for navigation
        public void GoToDemo()
        {
            //navigate to demo page.
        }
    }
}
