using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Tema_3.PageObjects.PageDemositeUrl
{
    partial class AdminPageDemositeUrl
    {
        public IWebElement RemoveAllProductButton => _driver.FindElement(By.XPath("/html/body/div/div/div/a[1]"));
        public IWebElement EditUserButton => _driver.FindElement(By.XPath("/html/body/div/div/div/table/tbody/tr[td[text()='Daniel']]/td[8]/a[1]"));
        public IWebElement UserNameAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[1]/input"));
        public IWebElement UserEmailAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[2]/input"));
        public IWebElement UserPhoneAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[3]/input"));
        private IWebElement UpdateUserButton => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/button"));
        public IWebElement ToastEditElementIsDisplayed => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div")));

    }
}
