using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects
{
    partial class LoginPageDemoqaUrl
    { 
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement PasswordFieldTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password']")));
        private IWebElement AuthenticateButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@type='submit']")));
        private IWebElement LogoutButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a"));

    }
}
