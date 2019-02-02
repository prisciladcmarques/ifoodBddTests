Feature: Search something to eat
	In order to eating something
	As a hungry person
	I want to be search anithing to eat

@mytag
Scenario: Fill the bar search with CEP
	Given I have entered in ifood home page
	And I fill the bar search with the CEP '32015540'
	When I press the Buscar button
	Then I go to the address page

Scenario: Fill the bar search with my number
	Given I have entered in ifood home page
	And I fill the bar search with the CEP '32015540'
	When I press the Buscar button
	Then I go to the address page

