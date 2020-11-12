using NUnit.Framework;
using Tema_3.PageObjects;
using Tema_3.PageObjects.PageDemoqaUrl;

namespace Tema_3
{
    [TestFixture]
    class TestsDemoqaUrl : Hooks
    {
        [Test]
        public void ValidateRegistrationTextBox()
        {
            // Arrange
            Navigate("https://demoqa.com/automation-practice-form");
            FormPageDemoqaUrl formPageDemoqaUrl = new FormPageDemoqaUrl(Driver);

            // Act
            formPageDemoqaUrl.RegistrationUserForm();

            // Assert
            Assert.IsTrue(formPageDemoqaUrl.ToastFormIsSubmited.Displayed);

        }


      [Test]
        public void ValidateRegistrationForm()
        {
            // Arrange
            Navigate("https://demoqa.com/text-box");
            ElementPageDemoqaUrl elementPageDemoqaUrl = new ElementPageDemoqaUrl(Driver);

            // Act
            elementPageDemoqaUrl.RegistrationUserElement();

            // Assert
            Assert.IsTrue(elementPageDemoqaUrl.ToastElementsIsSubmited.Displayed);

        }
    }
}