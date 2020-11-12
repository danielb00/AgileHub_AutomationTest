using NUnit.Framework;
using OpenQA.Selenium;
using Tema_3.PageObjects;
using Tema_3.PageObjects.PageDemositeUrl;

namespace Tema_3
{
    [TestFixture]
    class TestsDemositeUrl : Hooks
    {
        // A.	Logati-va in aplicatie.
        [Test, Order(1)]
        public void LoginWithValidUser()
        {
            // Arrange
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AuthenticationUserButton();

            // Act
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.AuthentificateUser("admin.test3@gmail.com", "password123");

            // Assert
            Assert.IsTrue(loginPageDemoqaUrl.LogoutButton.Displayed);

        }

        // B.	Adaugati in cos un produs ca si utilizator.
        [Test, Order(4)]
        public void AddProductToCartAsUser()
        {
            // Arrange
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AuthenticationUserButton();

            // Act
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.AuthentificateUser("adtestdaniel@gmail.com", "Test1111");
            homePageDemositeUrl.UserAddProductButton();

            // Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Telefon mobil Asus Zenfone 6");

        }
        // C.	Adaugati in cos un produs ca si admin.
        [Test, Order(3)]
        public void AddProductToCartAsAdminUser()
        {
            // Arrange
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AuthenticationUserButton();

            // Act
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.AuthentificateUser("admin.test3@gmail.com", "password123");
            homePageDemositeUrl.UserAdminAddProductButton();

            // Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Aparat foto digital Sony Cyber-Shot");

        }

        // D.	Faceti inscrierea si logati-va cu noul cont.
        [Test, Order(2)]
        public void RegisterAndLoginWithNewAccount()
        {
            // Arrange
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.RegiserUserButton();

            // Act
            RegisterDemositeUrl registerDemositeUrl = new RegisterDemositeUrl(Driver);
            registerDemositeUrl.RegiserUserForm();
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.AuthentificateUser("adtestdaniel@gmail.com", "Test1111");

            // Assert
            Assert.IsTrue(loginPageDemoqaUrl.LogoutButton.Displayed);

        }

        // E.	Logati-va si deconectati-va din site.
        [Test, Order(5)]
        public void LoginAndLogoutOfWebsite()
        {
            // Arrange
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            LoginWithValidUser();

            // Act
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.LogoutUser();

            // Assert
            Assert.IsTrue(homePageDemositeUrl.AuthenticationButton.Displayed);

        }

        // F.	Dati click pe fiecare meniu (orizontal).
        [Test, Order(6)]
        public void ClickOnEachHorizontalMenu()
        {

            //Arrange
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);

            //Act
            homePageDemositeUrl.ClickOnEachHorizontalMenu();

            //Assert
            Assert.IsTrue(homePageDemositeUrl.ViewDetailsButton.Displayed);
        }

        // G.	Ca si admin, dati click pe buton de administrare.
        [Test, Order(7)]
        public void AdminUserClickOnAdministrationButton()
        {
            // Arrange
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            LoginWithValidUser();
            homePageDemositeUrl.AdminButton.Click();

            //Act
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);

            //Assert
            Assert.IsTrue(adminPageDemositeUrl.RemoveAllProductButton.Displayed);
        }

        // H.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.
        [Test, Order(8)]
        public void AdminUserClickOnAdministrationButtonAndAccessUsersMenu()
        {
            // Arrange
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            LoginWithValidUser();
            homePageDemositeUrl.AdminButton.Click();
            homePageDemositeUrl.AdminUsersButton();

            //Act
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);

            //Assert
            Assert.IsTrue(adminPageDemositeUrl.EditUserButton.Displayed);
        }

        // I.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.
        [Test, Order(9)]
        public void AdminUserChooseUserAndEdit()
        {
            // Arrange
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            LoginWithValidUser();
            homePageDemositeUrl.AdminButton.Click();
            homePageDemositeUrl.AdminUsersButton();

            //Act
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            adminPageDemositeUrl.UpdateUser("danielb", "daniel@gmail.com", "0720123321");

            //Assert
            Assert.IsTrue(adminPageDemositeUrl.ToastEditElementIsDisplayed.Displayed);
        }

    }
}
