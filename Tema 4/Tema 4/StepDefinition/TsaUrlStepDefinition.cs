using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Tema_4.PageObjects;

namespace Tema_4.StepDefinition
{
    [Binding]
    public sealed class TsaUrlStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public TsaUrlStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate on teatrulsicaalexandrescu\.ro")]
        public void GivenINavigateOnTeatrulsicaalexandrescu_Ro()
        {
            Navigate("https://www.teatrulsicaalexandrescu.ro/?lang=en");
        }

        [When(@"I select the first person on the team and his first show")]
        public void WhenISelectTheFirstPersonOnTheTeamAndHisFirstShow()
        {
            HomePageTsaUrl homePageTsaUrl = new HomePageTsaUrl(Driver);
            homePageTsaUrl.NavigateTsaUrl();
        }

        [Then(@"I validated that the show is described\.")]
        public void ThenIValidatedThatTheShowIsDescribed_()
        {
            HomePageTsaUrl homePageTsaUrl = new HomePageTsaUrl(Driver);
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, 500)");
            Assert.IsTrue(homePageTsaUrl.MainPageShow.Displayed);
        }

    }
}
