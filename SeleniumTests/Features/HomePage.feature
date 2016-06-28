Feature: HomePage
	
Scenario: Open the login panel
	Given I am on the Xedo home page
	When I click the login button in the header
	Then the login panel should be open