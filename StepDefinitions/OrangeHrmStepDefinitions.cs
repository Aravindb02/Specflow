using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHrmStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"User is on orange hrm login page")]
        public void GivenUserIsOnOrangeHrmLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string username, string passwd)
        {
            IWebElement usernam = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            usernam.SendKeys(username);
            IWebElement password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys(passwd);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement login = _driver.FindElement(By.XPath("//button[@type='submit']"));
            login.Click();
            Thread.Sleep(1000);

        }

        [Then(@"User is navigated to the home page")]
        public void ThenUserIsNavigatedToTheHomePage()
        {
            IWebElement Admin = _driver.FindElement(By.XPath("//li[1]//a[1]//span[1]"));

            Admin.Click();
            Thread.Sleep(1000);
            _driver.Close();
        }
    }
}
