Feature: TsaUrlTestFeature
	In order to validate the first show of the first actor on the team list on the teatrulsicaalexandrescu.ro website
	Navigate on the teatrulsicaalexandrescu.ro website
    Click on Team and select the first person from the team
    Click on the first show of that person.

# Navigati catre pagina https://www.teatrulsicaalexandrescu.ro/?lang=en. Dati click pe Team(engleza) si selectati prima persoana din echipa. Dati click pe primul spectacol al persoanei respective.
@NavigateOnTsa
Scenario: ValidateShowFirstActor
	Given I navigate on teatrulsicaalexandrescu.ro
	When I select the first person on the team and his first show
	Then I validated that the show is described.