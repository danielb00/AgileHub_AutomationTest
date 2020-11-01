using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects.PageDemositeUrl
{
    partial class RegisterDemositeUrl
    {
        private IWebElement RegisterEmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
        private IWebElement RegisterNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement RegisterPhoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[3]/input"));
        private IWebElement RegisterAddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[4]/textarea"));
        private IWebElement RegisterPasswordRepeatTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[6]/input"));
        private IWebElement RegisterInscriereButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));
        private IWebElement RegisterPasswordextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[5]/input"));
    }
}
