using OpenQA.Selenium;


namespace Tema_4.PageObjects
{
    partial class HomePageGoogleUrl
    {
        private IWebDriver _driver;
        public HomePageGoogleUrl(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AcceptGoogleCookies()
        {
            AcceptCookieButton.Click();
        }

        public void SearchGoogleImage(string search)
        {
            SearchTextBox.SendKeys(search);
            SearchTextBox.SendKeys(Keys.Return);
        }
        public void SelectGoogleImage()
        {
            ImageButton.Click();
            SelectFirstImage.Click();
        }

    }

}
