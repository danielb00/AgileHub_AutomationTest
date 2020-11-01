using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Tema_3.PageObjects
{
    partial class HomePageUntoldUrl
    {
        private IWebElement MenuButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[3]/div/button")));
        private IWebElement HomeButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]")));
        public IWebElement VerifyUntoldWrapIsDisplayed => _driver.FindElement(By.XPath("//*[@id='untold-wrap']/div[3]/div[1]"));
    }
}
