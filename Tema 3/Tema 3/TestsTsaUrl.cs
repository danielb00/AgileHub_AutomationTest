using NUnit.Framework;
using OpenQA.Selenium;
using Tema_3.PageObjects;

namespace Tema_3
{
    [TestFixture]
    class TestsTsaUrl : Hooks
    {
        [Test]
        public void NavigateOnBrowserTsa()
        {
            // Arrange
            Navigate("https://www.teatrulsicaalexandrescu.ro/?lang=en");
            HomePageTsaUrl homePageTsaUrl = new HomePageTsaUrl(Driver);

            // Act
            homePageTsaUrl.NavigateTsaUrl();

            // Assert
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, 500)");
            Assert.IsTrue(homePageTsaUrl.VerifyElementsIsDisplayed.Displayed);

        }
    }
}
