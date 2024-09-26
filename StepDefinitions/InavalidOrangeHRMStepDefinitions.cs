using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class InavalidOrangeHRMStepDefinitions

    {
        IWebDriver _driver;
        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersAndInTheTextFields(string username, string passwd)
        {
            IWebElement usernam = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            usernam.SendKeys(username);
            IWebElement password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys(passwd);
            Thread.Sleep(1000);
        }

        [When(@"User clicks submit button")]
        public void WhenUserClicksSubmitButton()
        {
            IWebElement login = _driver.FindElement(By.XPath("//button[@type='submit']"));
            login.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User gets error message")]
        public void ThenUserGetsErrorMessage()
        {
            IWebElement error = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text'] "));
            var errorMessage = error.Text;
            Assert.AreEqual(errorMessage, "Invalid credentials");
            Thread.Sleep(1000);
            _driver.Close();
        }
    }
}
