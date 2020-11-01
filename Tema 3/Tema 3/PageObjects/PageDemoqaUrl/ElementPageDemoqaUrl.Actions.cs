using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects.PageDemoqaUrl
{
    partial class ElementPageDemoqaUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public ElementPageDemoqaUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }
        public void RegistrationUserElement()
        {
            FullNameTextBox.SendKeys("Daniel Boariu");
            EmailTextBox.SendKeys("boariu.daniel@yahoo.com");
            CurrentAddressTextBox.SendKeys("Cartier Tractorul");
            PermanentAddressTextBox.SendKeys("Brasov");
            SubmitButton.Click();
        }
    }
}
