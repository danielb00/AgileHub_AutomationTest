using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tema_3
{
    public class Hooks
    {
        protected IWebDriver Driver;

        [SetUp]

        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
