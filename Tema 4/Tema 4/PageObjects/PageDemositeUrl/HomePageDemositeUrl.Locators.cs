using OpenQA.Selenium;

namespace Tema_4.PageObjects
{
    partial class HomePageDemositeUrl
    {
        private IWebDriver _driver;

        public HomePageDemositeUrl(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AuthenticationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        private IWebElement RegiserButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a"));
        private IWebElement UsersButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));
        public IWebElement ViewDetailsButton => _driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-block']"));
        public IWebElement AddToShoppingCartButton => _driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-block']"));
        public IWebElement TelefoaneButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]/a"));
        public IWebElement FotoButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]/a"));
        public IWebElement LaptopuriButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]/a"));
        public IWebElement CartiButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));
        public IWebElement AccesoriiButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[5]/a"));
        public IWebElement AdminButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[3]/a"));
        
    }       
}
