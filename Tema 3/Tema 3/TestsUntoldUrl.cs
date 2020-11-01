using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.IsTrue(homePageUntoldUrl.VerifyUntoldWrapIsDisplayed.Displayed);

        }
        
    }
}
