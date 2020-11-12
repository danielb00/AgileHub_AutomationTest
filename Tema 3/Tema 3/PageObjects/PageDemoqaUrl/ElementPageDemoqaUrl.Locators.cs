using OpenQA.Selenium;


namespace Tema_3.PageObjects.PageDemoqaUrl
{
    partial class ElementPageDemoqaUrl
    {
        private IWebElement FullNameTextBox => _driver.FindElement(By.XPath("//*[@id='userName']"));
        private IWebElement EmailTextBox => _driver.FindElement(By.XPath("//*[@id='userEmail']"));
        private IWebElement CurrentAddressTextBox => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement PermanentAddressTextBox => _driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement ToastElementsIsSubmited => _driver.FindElement(By.XPath("//*[@id='output']"));
    }
}
