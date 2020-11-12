﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tema_4.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DemositeUrlTestFeature")]
    public partial class DemositeUrlTestFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DemositeUrlTestFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "DemositeUrlTestFeature", @"	In order to validate demosite.casqad.org website.
	Navigate on the demosite.casqad.org website.
    Login to the application.
    Add a product to the cart as a user.
	Add a product to the cart as admin.
	Register and log in with the new account.
	Log in and log out of the site.
	Click on each menu (horizontal).
	As an admin, click the administration button.
	As admin, click on the administration button and access the Users menu.
	As admin, click the admin button and access the Users menu, choose a user and edit.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("001 LoginWithValidUser")]
        [NUnit.Framework.CategoryAttribute("LoginWithValidUser")]
        public virtual void _001LoginWithValidUser()
        {
            string[] tagsOfScenario = new string[] {
                    "LoginWithValidUser"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("001 LoginWithValidUser", null, tagsOfScenario, argumentsOfScenario);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 18
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table3.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 19
 testRunner.When("I login with following credentials", ((string)(null)), table3, "When ");
#line hidden
#line 22
 testRunner.Then("I validated if the logout button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("004 AddProductToCartAsUser")]
        [NUnit.Framework.CategoryAttribute("AddProductToCartAsUser")]
        public virtual void _004AddProductToCartAsUser()
        {
            string[] tagsOfScenario = new string[] {
                    "AddProductToCartAsUser"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("004 AddProductToCartAsUser", null, tagsOfScenario, argumentsOfScenario);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table4.AddRow(new string[] {
                            "adtestdaniel@gmail.com",
                            "Test1111"});
#line 29
 testRunner.When("I login with following credentials", ((string)(null)), table4, "When ");
#line hidden
#line 32
 testRunner.And("I added a product as a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("I validated if the product it was added as user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("003 AddProductToCartAsAdminUser")]
        [NUnit.Framework.CategoryAttribute("AddProductToCartAsAdminUser")]
        public virtual void _003AddProductToCartAsAdminUser()
        {
            string[] tagsOfScenario = new string[] {
                    "AddProductToCartAsAdminUser"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("003 AddProductToCartAsAdminUser", null, tagsOfScenario, argumentsOfScenario);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table5.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 40
 testRunner.When("I login with following credentials", ((string)(null)), table5, "When ");
#line hidden
#line 43
 testRunner.And("I added a product as admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.Then("I validated if the product it was added as admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("002 RegisterAndLoginWithNewAccount")]
        [NUnit.Framework.CategoryAttribute("RegisterAndLoginWithNewAccount")]
        [NUnit.Framework.TestCaseAttribute("Daniel", "adtestdaniel@gmail.com", "0740123321", "Brasov", "Test1111", "Test1111", null)]
        public virtual void _002RegisterAndLoginWithNewAccount(string registerNameValue, string registerEmailValue, string registerPhoneValue, string registerAddressValue, string registerPasswordValue, string registerPasswordRepeatValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegisterAndLoginWithNewAccount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("registerNameValue", registerNameValue);
            argumentsOfScenario.Add("registerEmailValue", registerEmailValue);
            argumentsOfScenario.Add("registerPhoneValue", registerPhoneValue);
            argumentsOfScenario.Add("registerAddressValue", registerAddressValue);
            argumentsOfScenario.Add("registerPasswordValue", registerPasswordValue);
            argumentsOfScenario.Add("registerPasswordRepeatValue", registerPasswordRepeatValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("002 RegisterAndLoginWithNewAccount", null, tagsOfScenario, argumentsOfScenario);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 50
 testRunner.Given("I navigate to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "registerName",
                            "registerEmail",
                            "registerPhone",
                            "registerAddress",
                            "registerPassword",
                            "registerPasswordRepeat"});
                table6.AddRow(new string[] {
                            string.Format("{0}", registerNameValue),
                            string.Format("{0}", registerEmailValue),
                            string.Format("{0}", registerPhoneValue),
                            string.Format("{0}", registerAddressValue),
                            string.Format("{0}", registerPasswordValue),
                            string.Format("{0}", registerPasswordRepeatValue)});
#line 51
 testRunner.When("I register new user", ((string)(null)), table6, "When ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table7.AddRow(new string[] {
                            string.Format("{0}", registerEmailValue),
                            string.Format("{0}", registerPasswordValue)});
#line 54
 testRunner.And("I login with following credentials", ((string)(null)), table7, "And ");
#line hidden
#line 57
 testRunner.Then("I validated if the logout button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("005 LoginAndLogoutOfWebsite")]
        [NUnit.Framework.CategoryAttribute("LoginAndLogoutOfWebsite")]
        public virtual void _005LoginAndLogoutOfWebsite()
        {
            string[] tagsOfScenario = new string[] {
                    "LoginAndLogoutOfWebsite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("005 LoginAndLogoutOfWebsite", null, tagsOfScenario, argumentsOfScenario);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 67
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table8.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 68
 testRunner.When("I login with following credentials", ((string)(null)), table8, "When ");
#line hidden
#line 71
 testRunner.And("I logout of the account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("I validated if the authentication button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("006 ClickOnEachHorizontalMenu")]
        [NUnit.Framework.CategoryAttribute("ClickOnEachHorizontalMenu")]
        public virtual void _006ClickOnEachHorizontalMenu()
        {
            string[] tagsOfScenario = new string[] {
                    "ClickOnEachHorizontalMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("006 ClickOnEachHorizontalMenu", null, tagsOfScenario, argumentsOfScenario);
#line 77
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 78
 testRunner.Given("I navigate on Demosite website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 79
 testRunner.When("I clicked on each horizontal menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("I validated if the view detail button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("007 AdminUserClickOnAdministrationButton")]
        [NUnit.Framework.CategoryAttribute("AdminUserClickOnAdministrationButton")]
        public virtual void _007AdminUserClickOnAdministrationButton()
        {
            string[] tagsOfScenario = new string[] {
                    "AdminUserClickOnAdministrationButton"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("007 AdminUserClickOnAdministrationButton", null, tagsOfScenario, argumentsOfScenario);
#line 85
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 86
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table9.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 87
 testRunner.When("I login with following credentials", ((string)(null)), table9, "When ");
#line hidden
#line 90
 testRunner.And("Click on administration button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("I validated if remove all product button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("008 AdminUserClickOnAdministrationButtonAndAccessUsersMenu")]
        [NUnit.Framework.CategoryAttribute("AdminUserClickOnAdministrationButtonAndAccessUsersMenu")]
        public virtual void _008AdminUserClickOnAdministrationButtonAndAccessUsersMenu()
        {
            string[] tagsOfScenario = new string[] {
                    "AdminUserClickOnAdministrationButtonAndAccessUsersMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("008 AdminUserClickOnAdministrationButtonAndAccessUsersMenu", null, tagsOfScenario, argumentsOfScenario);
#line 96
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 97
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table10.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 98
 testRunner.When("I login with following credentials", ((string)(null)), table10, "When ");
#line hidden
#line 101
 testRunner.And("Click on administration button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("Click on users button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.Then("I validated if edit user button is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("009 AdminUserChooseUserAndEdit")]
        [NUnit.Framework.CategoryAttribute("AdminUserChooseUserAndEdit")]
        public virtual void _009AdminUserChooseUserAndEdit()
        {
            string[] tagsOfScenario = new string[] {
                    "AdminUserChooseUserAndEdit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("009 AdminUserChooseUserAndEdit", null, tagsOfScenario, argumentsOfScenario);
#line 108
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 109
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table11.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 110
 testRunner.When("I login with following credentials", ((string)(null)), table11, "When ");
#line hidden
#line 113
 testRunner.And("Click on administration button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("Click on users button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "userName",
                            "userEmail",
                            "userPhone"});
                table12.AddRow(new string[] {
                            "danielb",
                            "daniel@gmail.com",
                            "0720123321"});
#line 115
 testRunner.And("I edit an user", ((string)(null)), table12, "And ");
#line hidden
#line 118
 testRunner.Then("I validated if the toast edit element is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("010 DeleteEditedUser")]
        [NUnit.Framework.CategoryAttribute("DeleteEditedUser")]
        public virtual void _010DeleteEditedUser()
        {
            string[] tagsOfScenario = new string[] {
                    "DeleteEditedUser"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("010 DeleteEditedUser", null, tagsOfScenario, argumentsOfScenario);
#line 123
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 124
 testRunner.Given("I navigate to authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "userEmail",
                            "userPassword"});
                table13.AddRow(new string[] {
                            "admin.test3@gmail.com",
                            "password123"});
#line 125
 testRunner.When("I login with following credentials", ((string)(null)), table13, "When ");
#line hidden
#line 128
 testRunner.And("Click on administration button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And("Click on users button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("I delete edited user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.Then("I validated if the deleted user isn\'t displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
