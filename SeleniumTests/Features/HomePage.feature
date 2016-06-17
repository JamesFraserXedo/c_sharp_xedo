Feature: HomePage
	
@mytag
Scenario: Open the login panel
	Given I am on the Xedo home page
	When I click the login button in the header
	Then the login panel should be open

Scenario: Check the Xedo homepage
	Given I have passed the Xedo exclusive access
	And I am on the Xedo home page
	Then The main image content is visible