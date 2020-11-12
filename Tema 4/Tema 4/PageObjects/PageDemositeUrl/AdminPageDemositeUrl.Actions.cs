using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tema_4.PageObjects.PageDemositeUrl
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

        public void UpdateUser(EditUserDemositeDto editUser)
        {
            EditUserButton.Click();
            UserNameAdminTextBox.Clear();
            UserNameAdminTextBox.SendKeys(editUser.userName);
            UserEmailAdminTextBox.Clear();
            UserEmailAdminTextBox.SendKeys(editUser.userEmail);
            UserPhoneAdminTextBox.Clear();
            UserPhoneAdminTextBox.SendKeys(editUser.userPhone);
            UpdateUserButton.Click();
        }

        public void DeleteUser()
        {
            DeleteUserButton.Click();
        }
    }
}
