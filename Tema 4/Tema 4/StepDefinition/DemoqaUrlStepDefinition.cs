using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tema_4.PageObjects;
using Tema_4.PageObjects.PageDemoqaUrl;

namespace Tema_4.StepDefinition
{
    [Binding]  //specflow argument - indicates that this class is binded with a feature file
    public sealed class DemoqaUrlStepDefinition : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public DemoqaUrlStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate on demoqa page")]
        public void GivenINavigateOnDemoqaPage()
        {
            Navigate("https://demoqa.com/text-box");
        }

        [When(@"I fill in all the fields and I clicked the submit button")]
        public void WhenIFillInAllTheFieldsAndIClickedTheSubmitButton(Table table)
        {
            var element = table.CreateInstance<ElementDemoqaDto>();
            ElementPageDemoqaUrl elementPageDemoqaUrl = new ElementPageDemoqaUrl(Driver);
            elementPageDemoqaUrl.RegistrationUserElement(element);
        }

        [Then(@"I validated if the text boxes was submited")]
        public void ThenIValidatedIfTheTextBoxesWasSubmited()
        {
            ElementPageDemoqaUrl elementPageDemoqaUrl = new ElementPageDemoqaUrl(Driver);
            Assert.IsTrue(elementPageDemoqaUrl.ToastElementsIsSubmited.Displayed);
        }




        [Given(@"I navigate on demoqa automation practice page")]
        public void GivenINavigateOnDemoqaAutomationPracticePage()
        {
            Navigate("https://demoqa.com/automation-practice-form");
        }

        [When(@"I fill in all the registration form and I clicked the submit button")]
        public void WhenIFillInAllTheRegistrationFormAndIClickedTheSubmitButton(Table table)
        {
            var form = table.CreateInstance<FormDemoqaDto>();
            FormPageDemoqaUrl formPageDemoqaUrl = new FormPageDemoqaUrl(Driver);
            formPageDemoqaUrl.RegistrationUserForm(form);
        }

        [Then(@"I validated if the form was submited")]
        public void ThenIValidatedIfTheFormWasSubmited()
        {
            FormPageDemoqaUrl formPageDemoqaUrl = new FormPageDemoqaUrl(Driver);
            Assert.IsTrue(formPageDemoqaUrl.ToastFormIsSubmited.Displayed);
        }
    }
}
