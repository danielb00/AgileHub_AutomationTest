using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema_4.PageObjects
{
    partial class HomePageTsaUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePageTsaUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }
        public void NavigateTsaUrl()
        {
            TeamButton.Click();
            ActorImageButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 600)");
            ShowsButton.Click();
        }
    }
}
