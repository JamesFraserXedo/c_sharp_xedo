Feature: QuickTryOn - Dates

Background: 
	Given I am on the Xedo QuickTryOn page

Scenario: Enter Preferred Try On date
	When I enter a preferred Try On date
	Then this should be confirmed on my Try On order

Scenario: Change Preferred Try On date
	Given that I have previously entered a Try On delivery date
	But I havent confirmed my order yet
	When I then amend my Try On delivery date
	Then the new date should be updated on my Try On order