using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FacebookClasses
{
    class Execution
    {
        private string web_title;

        Setup setup = new Setup();
        #region
        By CreateAccountButton = By.XPath("//a[contains(text(),'Create New Account')]");
        By FacebookToEnglish = By.XPath("//*[contains(text(),'English (US)')]");
        By Facebook_Moto = By.XPath("//*[contains(text(),'Connect with friends and the world around you on Facebook.')]");
        By first_name_field = By.XPath("//div//input[@name='firstname']");
        By last_name_field = By.XPath("//div//input[@name='lastname']");
        By mobile_field = By.XPath("//div//input[@name='reg_email__']");
        By password_field = By.XPath("//div//input[@name='reg_passwd__']");
        By day_dropdown = By.Id("day");
        By day_option = By.XPath("//select[@id='day']//option[@value = '5']");
        By month_dropdown = By.Id("month");
        By month_option = By.XPath("//select[@id='month']//option[@value = '3']");
        By year_dropdown = By.Id("year");
        By year_option = By.XPath("//select[@id='year']//option[@value = '2000']");
        By female_option = By.XPath("//input[@name='sex' and @value='1']");
        #endregion

        public void fill_sing_up_section(IWebDriver driver)
        {
            IWebElement element;
            setup.verify_element_present(driver, FacebookToEnglish);
            element = driver.FindElement(FacebookToEnglish);
            setup.Click(element);

            
            Assert.AreEqual("Connect with friends and the world around you on Facebook.", driver.FindElement(Facebook_Moto).Text);
            
            setup.verify_element_present(driver, CreateAccountButton);
            element = driver.FindElement(CreateAccountButton);
            setup.Click(element);

            setup.verify_element_present(driver, first_name_field);
            element = driver.FindElement(first_name_field);
            setup.SendText(element, "Diego");

            setup.verify_element_present(driver, last_name_field);
            element = driver.FindElement(last_name_field);
            setup.SendText(element, "Brockman");

            setup.verify_element_present(driver, mobile_field);
            element = driver.FindElement(mobile_field);
            setup.SendText(element, "123456789");

            setup.verify_element_present(driver, password_field);
            element = driver.FindElement(password_field);
            setup.SendText(element, "Secret1234");

            setup.verify_element_present(driver, day_dropdown);
            element = driver.FindElement(day_dropdown);
            setup.Click(element);

            setup.verify_element_present(driver, day_option);
            element = driver.FindElement(day_option);
            setup.Click(element);

            setup.verify_element_present(driver, day_dropdown);
            element = driver.FindElement(day_dropdown);
            setup.Click(element);


            setup.verify_element_present(driver, month_option);
            element = driver.FindElement(month_option);
            setup.Click(element);

            setup.verify_element_present(driver, year_dropdown);
            element = driver.FindElement(year_dropdown);
            setup.Click(element);

            setup.verify_element_present(driver, year_option);
            element = driver.FindElement(year_option);
            setup.Click(element);

            setup.verify_element_present(driver, female_option);
            element = driver.FindElement(female_option);
            setup.Click(element);
        }

        public void validate_text(IWebDriver driver)
        {
            IWebElement element;
            element = driver.FindElement(Facebook_Moto);
            Assert.AreEqual("Connect with friends and the world around you on Facebook.", driver.FindElement(Facebook_Moto).Text);
        }
 

        public string Web_title
        {
            get{ return web_title; }
            set{
                Assert.AreEqual("Facebook - Log In or Sign Up", value);
                web_title = value;               
            }
        }
    }
}
