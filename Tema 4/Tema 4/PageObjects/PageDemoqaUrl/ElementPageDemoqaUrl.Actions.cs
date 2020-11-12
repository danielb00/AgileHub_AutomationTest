using OpenQA.Selenium;


namespace Tema_4.PageObjects.PageDemoqaUrl
{
    partial class ElementPageDemoqaUrl
    {
        private IWebDriver _driver;
        public ElementPageDemoqaUrl(IWebDriver driver)
        {
            _driver = driver;
        }
        public void RegistrationUserElement(ElementDemoqaDto element)
        {
            FullNameTextBox.SendKeys(element.fullName);
            EmailTextBox.SendKeys(element.emailText);
            CurrentAddressTextBox.SendKeys(element.currentAddress);
            PermanentAddressTextBox.SendKeys(element.permanentAddress);
            SubmitButton.Click();
        }
    }
}
