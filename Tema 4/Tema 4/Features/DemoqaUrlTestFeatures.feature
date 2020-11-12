Feature: DemoqaUrlTestFeatures
	In order to validate text boxes and form on the demoqa.com website
	Navigate on the demoqa.com website
    Fill in all the fields
    Click on the Submit button.


# Navigati catre pagina https://demoqa.com/text-box Completati TOATE campurile si apasati pe butonul de Submit.
@TextBoxesDemoqaUrl
Scenario: ValidateTextBoxOnDemoqaPage
	Given I navigate on demoqa page
	When I fill in all the fields and I clicked the submit button
	| fullName          |   emailText				|   currentAddress		|	permanentAddress	|
	| Daniel Boariu		|   boariu.daniel@yahoo.com	|	Cartier Tractorul	|	Brasov				|
	Then I validated if the text boxes was submited

# Navigati catre pagina https://demoqa.com/automation-practice-form Completati TOATE campurile si apasati pe butonul de Submit.
@FormDemoqaUrl
Scenario: ValidateFormOnDemoqaPage
	Given I navigate on demoqa automation practice page
	When I fill in all the registration form and I clicked the submit button
	|	firstName	|	lastname	|   emailText			|	mobilePhone	|	subjectsText	|	addressText	|	stateText	|	cityText	|
	|	Boariu		|   Daniel		|	danielb@yahoo.com	|	0742819864	|	Automation		|	Brasov		|	Haryana		|	Karnal		|
	Then I validated if the form was submited


