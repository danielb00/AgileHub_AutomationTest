using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3.PageObjects
{
    partial class HomePageDemositeUrl
    {
        public void AuthenticationUserButton()
        {
            AuthenticationButton.Click();
        }
        public void RegiserUserButton()
        {
            RegiserButton.Click();
        }
        public void AdminUsersButton()
        {
            UsersButton.Click();
        }

        public void UserAddProductButton()
        {
            TelefoaneButton.Click();
            ViewDetailsButton.Click();
            AddToShoppingCartButton.Click();
           
        }
        public void UserAdminAddProductButton()
        {
            FotoButton.Click();
            ViewDetailsButton.Click();
            AddToShoppingCartButton.Click();
        }

        public void ClickOnEachHorizontalMenu()
        {
            LaptopuriButton.Click();
            TelefoaneButton.Click();
            FotoButton.Click();
            CartiButton.Click();
            AccesoriiButton.Click();

        }
    }
}
