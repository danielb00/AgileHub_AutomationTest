using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema_3.PageObjects.PageDemositeUrl
{
    partial class AdminPageDemositeUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public AdminPageDemositeUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

            _driverWait.IgnoreExceptionTypes();
        }

        public void UpdateUser(string name, string email, string phone)
        {
            EditUserButton.Click();
            UserNameAdminTextBox.Clear();
            UserNameAdminTextBox.SendKeys(name);
            UserEmailAdminTextBox.Clear();
            UserEmailAdminTextBox.SendKeys(email);
            UserPhoneAdminTextBox.Clear();
            UserPhoneAdminTextBox.SendKeys(phone);
            UpdateUserButton.Click();
        }
    }
}
