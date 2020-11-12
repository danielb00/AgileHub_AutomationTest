using NUnit.Framework;
using TechTalk.SpecFlow;
using Tema_4.PageObjects;

namespace Tema_4.StepDefinition
{
    [Binding]
    public sealed class GoogleUrlStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public GoogleUrlStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate on Google page")]
        public void GivenINavigateOnGooglePage()
        {
            Navigate("https://www.google.com/");
            Driver.SwitchTo().Frame(0);
        }

        [Given(@"I accepted the google cookie")]
        public void GivenIAcceptedTheGoogleCookie()
        {
            HomePageGoogleUrl homePageGoogleUrl = new HomePageGoogleUrl(Driver);
            homePageGoogleUrl.AcceptGoogleCookies();
        }

        [When(@"I searched the image and I selected it")]
        public void WhenISearchedTheImageAndISelectedIt()
        {
            HomePageGoogleUrl homePageGoogleUrl = new HomePageGoogleUrl(Driver);
            homePageGoogleUrl.SearchGoogleImage("paris");
            homePageGoogleUrl.SelectGoogleImage();
        }

        [Then(@"I validated that the searched image appears")]
        public void ThenIValidatedThatTheSearchedImageAppears()
        {
            HomePageGoogleUrl homePageGoogleUrl = new HomePageGoogleUrl(Driver);
            Assert.IsTrue(homePageGoogleUrl.ImageSection.Displayed);
            Driver.Navigate().Back();
        }



    }
}
