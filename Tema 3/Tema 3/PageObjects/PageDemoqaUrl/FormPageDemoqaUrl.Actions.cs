using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema_3.PageObjects
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
        public void RegistrationUserForm()
        {
            FirstNameTextBox.SendKeys("Boariu");
            LastNameTextBox.SendKeys("Daniel");
            EmailTextBox.SendKeys("danielb@yahoo.com");
            GenderRadioButton.Click();
            MobilePhoneTextBox.SendKeys("0742819864");
            DateTextBox.Click();
            DatePicker.Click();
            SubjectsTextBox.SendKeys("Automation");
            SubjectsTextBox.SendKeys(Keys.Tab);
            AddressTextBox.SendKeys("Brasov");
            StateTextBox.SendKeys("Haryana");
            StateTextBox.SendKeys(Keys.Tab);
            CityTextBox.SendKeys("Karnal");
            CityTextBox.SendKeys(Keys.Tab);
            SubmitButton.Click();
        }

    }
}
