Feature: GoogleUrlTestFeature
	In order to validate the search on the Google.com website
	Navigate on the Google.com website
    Enter the value 'paris' in the search field and I pressed the search button
    Select the 'images' option.
    Select the first image found.
    Return to the image page.

# Navigati pe https://www.google.com/. Scrieti in campul de search “paris” si apasati pe butonul Google Search. Selectati “Images” din optiuni. Selectati prima imagine gasita.  Dati Back catre pagina cu imagini.
@SearchGoogleUrl
Scenario: ValidateSearchOnGooglePage
	Given I navigate on Google page
	And I accepted the google cookie
	When I searched the image and I selected it 
	Then I validated that the searched image appears


