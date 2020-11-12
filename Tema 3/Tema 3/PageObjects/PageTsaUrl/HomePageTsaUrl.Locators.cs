using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects
{
    partial class HomePageTsaUrl
    {
        private IWebElement TeamButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu-item-2914']/a/span[2]")));
        private IWebElement ActorImageButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-masonry-1-item-2697']/figure/div/div")));
        private IWebElement ShowsButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]")));
        public IWebElement MainPageShow => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[2]/div/div/h3")));
    }
}
