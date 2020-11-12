using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Tema_3.PageObjects
{
    partial class LoginPageDemoqaUrl
    { 
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement PasswordFieldTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password']")));
        private IWebElement AuthenticateButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@type='submit']")));
        public IWebElement LogoutButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));

    }
}
