using NUnit.Framework;
using Tema_3.PageObjects;

namespace Tema_3
{
    [TestFixture]
    class TestsUntoldUrl : Hooks
    {
       
        [Test]
        public void NavigateOnBrowserUntold()
        {
            // Arrange
            Navigate("https://untold.com/");
            HomePageUntoldUrl homePageUntoldUrl = new HomePageUntoldUrl(Driver);

            // Act
            homePageUntoldUrl.NavigateUntoldUrl();

            // Assert
            Assert.IsTrue(homePageUntoldUrl.UntoldWrap.Displayed);

        }
        
    }
}
