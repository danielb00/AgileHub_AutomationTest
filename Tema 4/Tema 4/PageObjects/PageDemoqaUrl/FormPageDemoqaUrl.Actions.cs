using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Tema_4.PageObjects
{
    partial class FormPageDemoqaUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public FormPageDemoqaUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }
        public void RegistrationUserForm(FormDemoqaDto form)
        {
            FirstNameTextBox.SendKeys(form.firstName);
            LastNameTextBox.SendKeys(form.lastName);
            EmailTextBox.SendKeys(form.emailText);
            GenderRadioButton.Click();
            MobilePhoneTextBox.SendKeys(form.mobilePhone);
            DateTextBox.Click();
            DatePicker.Click();
            SubjectsTextBox.SendKeys(form.subjectsText);
            SubjectsTextBox.SendKeys(Keys.Tab);
            AddressTextBox.SendKeys(form.addressText);
            StateTextBox.SendKeys(form.stateText);
            StateTextBox.SendKeys(Keys.Tab);
            CityTextBox.SendKeys(form.cityText);
            CityTextBox.SendKeys(Keys.Tab);
            SubmitButton.Click();
        }

    }
}
