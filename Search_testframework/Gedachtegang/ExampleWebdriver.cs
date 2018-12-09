using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Search_testframework.Framework;

namespace Search_testframework
{
    public class ExampleWebdriver
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://nos.nl/";
            webDriver.FindElement(By.Id("nav-zoeken")).Click();
            webDriver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/form[1]/fieldset[1]/input[1]")).SendKeys("vandaag" + Keys.Enter);
        }
    }
}
