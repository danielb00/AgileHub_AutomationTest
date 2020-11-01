using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema_3.PageObjects
{
    partial class HomePageGoogleUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePageGoogleUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }

        public void AcceptGoogleCookies()
        {
            AcceptCookieButton.Click();
        }

        public void SearchGoogleImage(string search)
        {
            SearchTextBox.SendKeys(search);
            SearchTextBox.SendKeys(Keys.Return);
        }
        public void SelectGoogleImage()
        {
            ImageButton.Click();
            SelectFirstImage.Click();
        }

    }

}
