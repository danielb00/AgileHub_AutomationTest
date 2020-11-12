using OpenQA.Selenium;


namespace Tema_4.PageObjects.PageDemositeUrl
{
    partial class RegisterDemositeUrl
    {
        private IWebDriver _driver;
        
        public RegisterDemositeUrl(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void RegiserUserForm(RegisterDemositeDto registerUser)
        {
            RegisterNameTextBox.SendKeys(registerUser.registerName);
            RegisterEmailTextBox.SendKeys(registerUser.registerEmail);
            RegisterPhoneTextBox.SendKeys(registerUser.registerPhone);
            RegisterAddressTextBox.SendKeys(registerUser.registerAddress);
            RegisterPasswordextBox.SendKeys(registerUser.registerPassword);
            RegisterPasswordRepeatTextBox.SendKeys(registerUser.registerPasswordRepeat);
            RegisterInscriereButton.Click();
        }
    }
}
