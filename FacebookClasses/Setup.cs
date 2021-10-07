using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FacebookClasses
{
    class Setup

    {
     
        IWebDriver driver;
        public IWebElement element;
        public IWebDriver SetUpDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://www.facebook.com/";
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

    }
}
