using NUnit.Framework;
using TechTalk.SpecFlow;
using Tema_4.PageObjects;

namespace Tema_4.StepDefinition
{
    [Binding]
    public sealed class UntoldUrlStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public UntoldUrlStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate on untold\.com")]
        public void GivenINavigateOnUntold_Com()
        {
            Navigate("https://untold.com/");
        }

        [When(@"Click on the menu and select the home page")]
        public void WhenClickOnTheMenuAndSelectTheHomePage()
        {
            HomePageUntoldUrl homePageUntoldUrl = new HomePageUntoldUrl(Driver);
            homePageUntoldUrl.NavigateUntoldUrl();
        }

        [Then(@"I validated the untold wrap is described")]
        public void ThenIValidatedTheUntoldWrapIsDescribed()
        {
            HomePageUntoldUrl homePageUntoldUrl = new HomePageUntoldUrl(Driver);
            Assert.IsTrue(homePageUntoldUrl.UntoldWrap.Displayed);
        }

    }
}
