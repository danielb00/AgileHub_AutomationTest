using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Tema_4.PageObjects
{
    partial class FormPageDemoqaUrl
    {
        private IWebElement FirstNameTextBox => _driver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement LastNameTextBox => _driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement EmailTextBox => _driver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement GenderRadioButton => _driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[1]/label"));
        private IWebElement MobilePhoneTextBox => _driver.FindElement(By.XPath("//input[@id='userNumber']"));
        private IWebElement DateTextBox => _driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
        public IWebElement DatePicker => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[4]/div[5]"));
        private IWebElement SubjectsTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='subjectsInput']")));

        //private IWebElement HobbiesCheckBox => _driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-1']"));
        private IWebElement AddressTextBox => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement StateTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='react-select-3-input']")));
        private IWebElement CityTextBox => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement ToastFormIsSubmited => _driver.FindElement(By.XPath("//*[@id='example-modal-sizes-title-lg']"));

    }
}
