using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema_3.PageObjects
{
    partial class HomePageUntoldUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePageUntoldUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }
        public void NavigateUntoldUrl()
        {
            MenuButton.Click();
            HomeButton.Click();
        }
    }
}
