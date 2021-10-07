using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace FacebookClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();
            IWebDriver driver = setup.SetUpDriver();
            Execution execution = new Execution(); 
            execution.fill_sing_up_section(driver);
            execution.validate_text(driver);
            execution.Web_title = driver.Title;
            driver.Close();
        }
    }
}
