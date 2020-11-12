Feature: UntoldUrlTestFeature
	In order to validate the menu on the untold.com website
	Navigate on the untold.com website
    Click on the menu and select the home page.

# Navigati catre pagina https://untold.com/. Dati click pe meniu si selectati pagina HOME.
@NavigateOnUntoldUrl
Scenario: ValidateMenuOnUntoldUrl
	Given I navigate on untold.com
	When Click on the menu and select the home page
	Then I validated the untold wrap is described