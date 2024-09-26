using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaBankStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is in  Registration form")]
        public void GivenUserIsInRegistrationForm()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            IWebElement registerbutton = _driver.FindElement(By.XPath("//a[normalize-space()='Register']"));
            registerbutton.Click();
        }

                    [When(@"User enters the first name ""([^""]*)"", last name ""([^""]*)"", address ""([^""]*)"", city ""([^""]*)"", state ""([^""]*)"", zip code ""([^""]*)"", phone number ""([^""]*)"", SSN ""([^""]*)"", username ""([^""]*)"", and password ""([^""]*)"" confirm ""([^""]*)""")]
        public void WhenUserEntersTheFirstNameLastNameAddressCityStateZipCodePhoneNumberSSNUsernameAndPasswordConfirm(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string ssn, string username, string password, string confirm)
       

        {
            IWebElement fname = _driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            fname.SendKeys(firstName);

            IWebElement lname = _driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            lname.SendKeys(lastName);

            IWebElement addres = _driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            addres.SendKeys(address);

            IWebElement cit = _driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            cit.SendKeys(city);

            IWebElement stat = _driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            stat.SendKeys(state);

            IWebElement zipcode = _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            zipcode.SendKeys(zipCode);

            IWebElement phonenumber = _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            phonenumber.SendKeys(phoneNumber);

            IWebElement ssno = _driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            ssno.SendKeys(ssn);

            IWebElement usn = _driver.FindElement(By.XPath("//input[@id='customer.username']"));
            usn.SendKeys(username);

            IWebElement pass = _driver.FindElement(By.XPath("//input[@id='customer.password']"));
            pass.SendKeys(password);

            IWebElement con = _driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            con.SendKeys(confirm);
            Thread.Sleep(1000);

        }

        [When(@"User clicks on  register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            IWebElement regis = _driver.FindElement(By.XPath("//input[@value='Register']"));
            regis.Click();
            Thread.Sleep(3000);
        }
        //[When(@"User enters ""([^""]*)"" and ""([^""]*)""")]
        //public void WhenUserEntersAnd(string username, string pass)
        //{
        //    IWebElement loguser = _driver.FindElement(By.XPath("//input[@name='username']"));
        //    loguser.SendKeys(username);

        //    IWebElement pas = _driver.FindElement(By.XPath("//input[@name='password']"));
        //    pas.SendKeys(pass);

            
        //}

        //[When(@"user click login")]
        //public void WhenUserClickLogin()
        //{
        //    IWebElement con = _driver.FindElement(By.XPath("//input[@value='Log In']"));
        //    con.Click();
        //}

        //[Then(@"user sees error message")]
        //public void ThenUserSeesErrorMessage()
        //{
        //    _driver.Quit();
        //}

        [Then(@"User see a  confirmation message")]
        public void ThenUserSeeAConfirmationMessage()
        {
            Console.WriteLine("Registered");
            _driver.Close();
        }
    }
}
