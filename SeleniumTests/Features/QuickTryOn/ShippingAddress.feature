Feature: ShippingAddress

Background: 
	Given I am on the Xedo QuickTryOn page

Scenario: New customer enters new valid address
	Given I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then The address should be checked by Fedex

Scenario: New customer enters new valid address and selects entered address
	Given I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the entered delivery address
	Then The address should be saved as entered

Scenario: New customer enters new valid address and selects suggested address from fedex
	Given I am not logged on to the site
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the suggested delivery address from Fedex
	Then the address should be saved as suggested by Fedex

Scenario: Customer enters invalid address(no address 1)
	Given I do not enter an address_1
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the address_1 field is required
	And The address should not be saved

Scenario: Customer enters invalid address(no city)
	Given I enter an address_1 4400 quality drive
	And I do not enter a city
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the city field is required
	And The address should not be saved

Scenario: Customer enters invalid address(no state)
	Given I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I do not select a state
	And I enter a zip code 38118
	When I confirm the delivery address
	Then I should be warned that the state field is required
	And The address should not be saved
	
Scenario: Customer enters invalid address(no zip code)
	Given I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I do not enter a zip
	When I confirm the delivery address
	Then I should be warned that the zip field is required
	And The address should not be saved

Scenario: Customer enters invalid address(invalid zip code)
	Given I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code xxxxx
	When I confirm the delivery address
	Then I should be warned that the zip code is invalid
	And The address should not be saved

Scenario: Existing logged on customer enters new valid address
	Given I am logged on to the site
	And I choose to enter the address
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	When I confirm the delivery address
	And I select the entered delivery address
	Then the address should be saved as entered into my address book
	And saved as the shipping address for the try on order

Scenario: Existing logged on customer enters new valid default address
	Given I am logged on to the site
	And I choose to enter the address
	And I enter an address_1 4400 quality drive
	And I enter a city Memphis
	And I select a state Tennessee
	And I enter a zip code 38118
	And I choose to save the address as my default address
	When I confirm the delivery address
	And I select the entered delivery address
	Then the address should be saved as entered into my address book as the default address
	And saved as the shipping address for the try on order