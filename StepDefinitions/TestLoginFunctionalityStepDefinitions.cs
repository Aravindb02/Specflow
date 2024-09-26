using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on Login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("User is on the login page");
        }

        [When(@"User enters username and password")]
        public void WhenUserEntersUsernameAndPassword()
        {
            Console.WriteLine("User enters the username and the password");

        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("Clicks on the login button");

        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Test user is on home page");
        }
    }
}
