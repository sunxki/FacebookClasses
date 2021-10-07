using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;




namespace FacebookClasses
{
    class Setup

    {
     
        public IWebDriver driver;
        public IWebElement element;
    
        public IWebDriver SetUpDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
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

        public void verify_element_present(IWebDriver driver,By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }



    }
}
