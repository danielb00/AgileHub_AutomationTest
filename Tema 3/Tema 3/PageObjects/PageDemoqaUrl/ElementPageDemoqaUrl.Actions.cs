using OpenQA.Selenium;


namespace Tema_3.PageObjects.PageDemoqaUrl
{
    partial class ElementPageDemoqaUrl
    {
        private IWebDriver _driver;
        public ElementPageDemoqaUrl(IWebDriver driver)
        {
            _driver = driver;
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
