using OpenQA.Selenium;


namespace Tema_3.PageObjects.PageDemositeUrl
{
    partial class RegisterDemositeUrl
    {
        private IWebDriver _driver;
        
        public RegisterDemositeUrl(IWebDriver driver)
        {
            _driver = driver;
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
