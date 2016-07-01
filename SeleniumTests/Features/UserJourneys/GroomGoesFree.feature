Feature: Groom Goes Free offer for 5 paid hires

Scenario Outline: Check that the groom pays normal price for less than 6 hires
	Given I am on the Xedo OutfitBuilder page
	And I am logged on to the site
	And I have added an outfit to my order
	And I have chosen a wedding date
	When I add <number> additional party members
	And I continue to payment
	And I complete billing
	Then the groom should be shown the quoted price

	Examples: 
	| number |
	| 0      |
	| 1      |
	| 2      |
	| 3      |
	| 4      |

Scenario Outline: Check that the groom pays nothing for 6 or more hires
	Given I am on the Xedo OutfitBuilder page
	And I am logged on to the site
	And I have added an outfit to my order
	And I have chosen a wedding date
	When I add <number> additional party members
	And I continue to payment
	And I complete billing
	Then the groom should get his outfit for free

	Examples: 
	| number |
	| 5      |
	| 6      |
	| 7      |
	| 8      |
	| 9      |
	| 10     |