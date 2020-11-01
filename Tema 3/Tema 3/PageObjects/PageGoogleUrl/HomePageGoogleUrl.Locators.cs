using OpenQA.Selenium;


namespace Tema_3.PageObjects
{
    partial class HomePageGoogleUrl
    {
        private IWebElement SearchTextBox => _driver.FindElement(By.CssSelector("input[name=q]"));
        private IWebElement ImageButton => _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
        private IWebElement SelectFirstImage => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));
        public IWebElement ImageSection => _driver.FindElement(By.XPath("//*[@id='Sva75c']"));
        private IWebElement AcceptCookieButton => _driver.FindElement(By.Id("introAgreeButton"));

    }
}
