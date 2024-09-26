using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public static void Setup()
        {
            Console.WriteLine("Runing before every scenario");
        }
        [AfterScenario]
        public static void TearDown()
        {
            Console.WriteLine("Running after test scenario");
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestContext.Progress.WriteLine("Before test run");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.Progress.WriteLine("After test run");
        }
        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("Brfore step");
        }
        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("After step");
        }
    }
}
