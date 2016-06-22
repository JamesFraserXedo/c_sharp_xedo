Feature: ShippingAddress

Scenario: 1 - New customer enters new valid address
	Given I am on the Xedo QuickTryOn page
	And I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then The address should be checked by Fedex

Scenario: 2 - new customer enters new valid address and selects entered address
	Given I am on the Xedo QuickTryOn page
	And I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the entered delivery address
	Then The address should be saved as entered

Scenario: 3 - new customer enters new valid address and selects suggested address from fedex
	Given I am on the Xedo QuickTryOn page
	And I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the suggested delivery address from Fedex
	Then the address should be saved as suggested by Fedex

Scenario: 4 - customer enters invalid address(no address 1)
	Given I am on the Xedo QuickTryOn page
	And I do not enter an address_1
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the address_1 field is required
	And The address should not be saved

Scenario: 5 - customer enters invalid address(no city)
	Given I am on the Xedo QuickTryOn page
	And I enter an address_1 4400 quality drive
	And I do not enter a city
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the city field is required
	And The address should not be saved

Scenario: 6 - customer enters invalid address(no state)
	Given I am on the Xedo QuickTryOn page
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I do not select a state
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the state field is required
	And The address should not be saved
	
Scenario: 7 - customer enters invalid address(no zip code)
	Given I am on the Xedo QuickTryOn page
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I do not enter a zip
	When I confirm the delivery address
	Then I should be warned that the zip field is required
	And The address should not be saved

Scenario: 8 - customer enters invalid address(invalid zip code)
	Given I am on the Xedo QuickTryOn page
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code xxxxx
	When I confirm the delivery address
	Then I should be warned that the zip code is invalid
	And The address should not be saved

Scenario: 9 - existing logged on customer enters new valid address
	Given I am on the Xedo QuickTryOn page
	And I am logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the entered delivery address
	Then the address should be saved as entered into my address book
	And saved as the shipping address for the try on order

Scenario: 10 - existing logged on customer enters new valid default address
	Given I am on the Xedo QuickTryOn page
	And I am logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	And I choose to save the address as my default address
	When I confirm the delivery address
	And I select the entered delivery address
	Then the address should be saved as entered into my address book as the default address
	And saved as the shipping address for the try on order