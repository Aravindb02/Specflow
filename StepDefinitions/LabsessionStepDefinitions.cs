using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LabsessionStepDefinitions
    {
        [Given(@"User is in Registration form")]
        public void GivenUserIsInRegistrationForm()
        {
            Console.WriteLine("User is in registration form");
        }

        [When(@"User enters the Credentials")]
        public void WhenUserEntersTheCredentials()
        {
            Console.WriteLine("User enter the credentials");
        }

        [When(@"User clicks on the register button")]
        public void WhenUserClicksOnTheRegisterButton()
        {
            Console.WriteLine("User clicks on the registration");
        }

        [Then(@"User sees confirmation message")]
        public void ThenUserSeesConfirmationMessage()
        {
            Console.WriteLine("USer sees confirmation");
        }

        [When(@"User enter first name ""([^""]*)"", last name ""([^""]*)"", address ""([^""]*)"", city ""([^""]*)"", state ""([^""]*)"", zip code ""([^""]*)"", phone number ""([^""]*)"", SSN ""([^""]*)"", username ""([^""]*)"", and password ""([^""]*)""")]
        public void WhenUserEnterFirstNameLastNameAddressCityStateZipCodePhoneNumberSSNUsernameAndPassword(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string ssn, string username, string password)
        {
            Console.WriteLine($" {firstName}, {lastName},  {address}, {city}, {state}, {zipCode},{phoneNumber}, {ssn}, {username},{password}");
        }

        [When(@"User click on register button")]
        public void WhenUserClickOnRegisterButton()
        {
            Console.WriteLine("User clicks on the registration button");
        }

        [Then(@"User see a confirmation message")]
        public void ThenUserSeeAConfirmationMessage()
        {
            Console.WriteLine("Confirmation");
        }
    }
}
