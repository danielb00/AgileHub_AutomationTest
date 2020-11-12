Feature: DemositeUrlTestFeature
	In order to validate demosite.casqad.org website.
	Navigate on the demosite.casqad.org website.
    Login to the application.
    Add a product to the cart as a user.
	Add a product to the cart as admin.
	Register and log in with the new account.
	Log in and log out of the site.
	Click on each menu (horizontal).
	As an admin, click the administration button.
	As admin, click on the administration button and access the Users menu.
	As admin, click the admin button and access the Users menu, choose a user and edit.

# Logati-va in aplicatie.

@LoginWithValidUser
Scenario: 001 LoginWithValidUser
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	Then I validated if the logout button is displayed

# Adaugati in cos un produs ca si utilizator.

@AddProductToCartAsUser
Scenario: 004 AddProductToCartAsUser
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	adtestdaniel@gmail.com	|   Test1111		|
	And I added a product as a user
	Then I validated if the product it was added as user

# Adaugati in cos un produs ca si admin.

@AddProductToCartAsAdminUser
Scenario: 003 AddProductToCartAsAdminUser
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And I added a product as admin user
	Then I validated if the product it was added as admin user

# Faceti inscrierea si logati-va cu noul cont.

@RegisterAndLoginWithNewAccount
Scenario: 002 RegisterAndLoginWithNewAccount
	Given I navigate to registration page 
	When I register new user
	|	registerName		|	registerEmail			|   registerPhone		|	registerAddress			|	registerPassword		|	registerPasswordRepeat			|	
	|	<registerNameValue>	|   <registerEmailValue>	|	<registerPhoneValue>|	<registerAddressValue>	|	<registerPasswordValue>	|	<registerPasswordRepeatValue>	|
	And I login with following credentials
	|	userEmail				|   userPassword			|
	|	<registerEmailValue>	|   <registerPasswordValue> |
	Then I validated if the logout button is displayed

Examples: 
	|	registerNameValue	|	registerEmailValue			|   registerPhoneValue	|	registerAddressValue	|	registerPasswordValue	|	registerPasswordRepeatValue	|	
	|	Daniel				|   adtestdaniel@gmail.com		|	0740123321			|	Brasov					|	Test1111				|	Test1111					|	

# Logati-va si deconectati-va din site.

@LoginAndLogoutOfWebsite
Scenario: 005 LoginAndLogoutOfWebsite
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And I logout of the account
	Then I validated if the authentication button is displayed

# Dati click pe fiecare meniu (orizontal).

@ClickOnEachHorizontalMenu
Scenario: 006 ClickOnEachHorizontalMenu
	Given I navigate on Demosite website
	When I clicked on each horizontal menu
	Then I validated if the view detail button is displayed

# Ca si admin, dati click pe buton de administrare.

@AdminUserClickOnAdministrationButton
Scenario: 007 AdminUserClickOnAdministrationButton
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And Click on administration button
	Then I validated if remove all product button is displayed

# Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.

@AdminUserClickOnAdministrationButtonAndAccessUsersMenu
Scenario: 008 AdminUserClickOnAdministrationButtonAndAccessUsersMenu
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And Click on administration button
	And Click on users button
	Then I validated if edit user button is displayed

# Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.

@AdminUserChooseUserAndEdit
Scenario: 009 AdminUserChooseUserAndEdit
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And Click on administration button
	And Click on users button
	And I edit an user
	|	userName	|	userEmail			|   userPhone	|	
	|	danielb		|   daniel@gmail.com	|	0720123321	|	
	Then I validated if the toast edit element is displayed
	
# Sterge userul editat

@DeleteEditedUser
Scenario: 010 DeleteEditedUser
	Given I navigate to authentication page
	When I login with following credentials
	|	userEmail				|   userPassword	|
	|	admin.test3@gmail.com	|   password123		|
	And Click on administration button
	And Click on users button	
	And I delete edited user
	Then I validated if the deleted user isn't displayed

