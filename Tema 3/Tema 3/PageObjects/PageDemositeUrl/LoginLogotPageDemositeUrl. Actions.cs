using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects
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

        public void AuthentificateUser(string user, string password)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            AuthenticateButton.Click();
        }
        public void LogoutUser()
        {
            LogoutButton.Click();
        }

    }
}
