using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tema_4.PageObjects;
using Tema_4.PageObjects.PageDemositeUrl;

namespace Tema_4.StepDefinition
{
    [Binding]
    public sealed class DemositeUrlStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public DemositeUrlStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        // Logati-va in aplicatie.

        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AuthenticationUserButton();
        }

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDemositeDto>();
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.AuthentificateUser(user);

        }

        [Then(@"I validated if the logout button is displayed")]
        public void ThenIValidatedIfTheLogoutButtonIsDisplayed()
        {
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            Assert.IsTrue(loginPageDemoqaUrl.LogoutButton.Displayed);
        }

        // Adaugati in cos un produs ca si utilizator.

        [When(@"I added a product as a user")]
        public void WhenIAddedProductAsAUser()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.UserAddProductButton();
        }

        [Then(@"I validated if the product it was added as user")]
        public void ThenIValidatedIfTheProductItWasAddedAsUser()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Telefon mobil Asus Zenfone 6");
        }

        // Adaugati in cos un produs ca si admin.

        [When(@"I added a product as admin user")]
        public void WhenIAddedAProductAsAdminUser()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.UserAdminAddProductButton();
        }

        [Then(@"I validated if the product it was added as admin user")]
        public void ThenIValidatedIfTheProductItWasAddedAsAdminUser()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Aparat foto digital Sony Cyber-Shot");
        }

        // Faceti inscrierea si logati-va cu noul cont.

        [Given(@"I navigate to registration page")]
        public void GivenINavigateToRegistrationPage()
        {
            Navigate("http://demosite.casqad.org/");
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.RegiserUserButton();
        }


        [When(@"I register new user")]
        public void WhenIRegisterNewUser(Table table)
        {  
            var registerUser = table.CreateInstance<RegisterDemositeDto>();
            RegisterDemositeUrl registerDemositeUrl = new RegisterDemositeUrl(Driver);
            registerDemositeUrl.RegiserUserForm(registerUser);
        }

        // Logati-va si deconectati-va din site.

        [When(@"I logout of the account")]
        public void WhenILogoutOfTheAccount()
        {
            LoginPageDemoqaUrl loginPageDemoqaUrl = new LoginPageDemoqaUrl(Driver);
            loginPageDemoqaUrl.LogoutUser();
        }

        [Then(@"I validated if the authentication button is displayed")]
        public void ThenIValidatedIfTheAuthenticationButtonIsDisplayed()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            Assert.IsTrue(homePageDemositeUrl.AuthenticationButton.Displayed);
        }

        // Dati click pe fiecare meniu (orizontal).

        [Given(@"I navigate on Demosite website")]
        public void GivenINavigateOnDemositeWebsite()
        {
            Navigate("http://demosite.casqad.org/");
        }

        [When(@"I clicked on each horizontal menu")]
        public void WhenIClickedOnEachHorizontalMenu()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.ClickOnEachHorizontalMenu();
        }

        [Then(@"I validated if the view detail button is displayed")]
        public void ThenIValidatedIfTheViewDetailButtonIsDisplayed()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            Assert.IsTrue(homePageDemositeUrl.ViewDetailsButton.Displayed);
        }

        // Ca si admin, dati click pe buton de administrare.

        [When(@"Click on administration button")]
        public void WhenClickOnAdministrationButton()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AdminButton.Click();
        }

        [Then(@"I validated if remove all product button is displayed")]
        public void ThenIValidatedIfRemoveAllProductButtonIsDisplayed()
        {
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            Assert.IsTrue(adminPageDemositeUrl.RemoveAllProductButton.Displayed);
        }

        // Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.

        [When(@"Click on users button")]
        public void WhenClickOnUsersButton()
        {
            HomePageDemositeUrl homePageDemositeUrl = new HomePageDemositeUrl(Driver);
            homePageDemositeUrl.AdminUsersButton();
        }

        [Then(@"I validated if edit user button is displayed")]
        public void ThenIValidatedIfEditUserButtonIsDisplayed()
        {
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            Assert.IsTrue(adminPageDemositeUrl.EditUserButton.Displayed);
        }

        // Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.

        [When(@"I edit an user")]
        public void WhenIEditAnUser(Table table)
        {
            var editUser = table.CreateInstance<EditUserDemositeDto>();
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            adminPageDemositeUrl.UpdateUser(editUser);
        }

        [Then(@"I validated if the toast edit element is displayed")]
        public void ThenIValidatedIfTheToastEditElementIsDisplayed()
        {
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            Assert.IsTrue(adminPageDemositeUrl.ToastEditElementIsDisplayed.Displayed);
        }

        // Sterge userul editat

        [When(@"I delete edited user")]
        public void WhenIDeleteEditedUser()
        {
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            adminPageDemositeUrl.DeleteUser();
        }

        [Then(@"I validated if the deleted user isn't displayed")]
        public void ThenIValidatedIfTheDeletedUserIsnTDisplayed()
        {
            AdminPageDemositeUrl adminPageDemositeUrl = new AdminPageDemositeUrl(Driver);
            Assert.IsFalse(adminPageDemositeUrl.UserDeletedIsDisplayed.Displayed);
        }

    }
}
