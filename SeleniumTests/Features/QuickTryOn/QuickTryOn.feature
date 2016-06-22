Feature: QuickTryOn - Dates

Scenario: 1 - Enter Preferred Try On date
	Given I am on the Xedo QuickTryOn page
	When I enter a preferred Try On date
	Then this should be confirmed on my Try On order

Scenario: 2 - Change Preferred Try On date
	Given I am on the Xedo QuickTryOn page
	And that I have previously entered a Try On delivery date
	And I havent confirmed my order yet
	When I then amend my Try On delivery date
	Then the new date should be updated on my Try On order