using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects.PageDemositeUrl
{
    partial class RegisterDemositeUrl
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public RegisterDemositeUrl(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();

        }
        
        public void RegiserUserForm()
        {
            RegisterNameTextBox.SendKeys("Daniel");
            RegisterEmailTextBox.SendKeys("adtestdaniel@gmail.com");
            RegisterPhoneTextBox.SendKeys("0740123321");
            RegisterAddressTextBox.SendKeys("Brasov");
            RegisterPasswordextBox.SendKeys("Test1111");
            RegisterPasswordRepeatTextBox.SendKeys("Test1111");
            RegisterInscriereButton.Click();
        }
    }
}
