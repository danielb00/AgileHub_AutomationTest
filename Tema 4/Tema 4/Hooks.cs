using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Tema_4
{
    [Binding]  //pentru a nu se deschide browser-ul de doua ori comentam [Binding]
    public class Hooks
    {
        protected static IWebDriver Driver;

        [BeforeScenario]

        public void BeforeScenario()
        {
            if (Driver is null)  // este o conditie pentru a nu se deschide browser-ul de cate mai multe ori (de cate teste sunt create)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
            }
        }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]

        public void AfterScenario()
        {
            if (!(Driver is null))
            {
                Driver.Quit();
                Driver = null;
            }
        }

    }
}
