using NUnit.Framework;
using Tema_3.PageObjects;

namespace Tema_3
{
    [TestFixture]
    class TestsGoogleUrl:Hooks
    {
        [Test]
        public void NavigateOnBrowserCheckSearchFunction()
        { 
            // Arrange
            Navigate("https://www.google.com/");
            HomePageGoogleUrl homePageGoogleUrl = new HomePageGoogleUrl(Driver);
            Driver.SwitchTo().Frame(0);
            homePageGoogleUrl.AcceptGoogleCookies();
            homePageGoogleUrl.SearchGoogleImage("paris");
            homePageGoogleUrl.SelectGoogleImage();

            // Act

            // Assert
            Assert.IsTrue(homePageGoogleUrl.ImageSection.Displayed);

            Driver.Navigate().Back();

        }
    }
}
