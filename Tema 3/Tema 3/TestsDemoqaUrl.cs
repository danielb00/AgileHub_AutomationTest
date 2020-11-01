using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_3.PageObjects;
using Tema_3.PageObjects.PageDemoqaUrl;

namespace Tema_3
{
    [TestFixture]
    class TestsDemoqaUrl : Hooks
    {
        [Test]
        public void RegistrationNewUser()
        {
            // Arrange
            Navigate("https://demoqa.com/automation-practice-form");
            FormPageDemoqaUrl formPageDemoqaUrl = new FormPageDemoqaUrl(Driver);

            // Act
            formPageDemoqaUrl.RegistrationUserForm();

            // Assert
            Assert.IsTrue(formPageDemoqaUrl.VerifyFormIsSubmited.Displayed);

        }

      //a. Logati-va in aplicatie.

      [Test]
        public void RegistrationNewElementOnUser()
        {
            // Arrange
            Navigate("https://demoqa.com/text-box");
            ElementPageDemoqaUrl elementPageDemoqaUrl = new ElementPageDemoqaUrl(Driver);

            // Act
            elementPageDemoqaUrl.RegistrationUserElement();

            // Assert
            Assert.IsTrue(elementPageDemoqaUrl.VerifyElementsIsSubmited.Displayed);

        }
    }
}