using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema_4.PageObjects
{
    partial class LoginPageDemoqaUrl
    {

        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPageDemoqaUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }

        public void AuthentificateUser(UserDemositeDto user)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user.userEmail);
            PasswordFieldTextBox.SendKeys(user.userPassword);
            AuthenticateButton.Click();
        }
        public void LogoutUser()
        {
            LogoutButton.Click();
        }

    }
}
