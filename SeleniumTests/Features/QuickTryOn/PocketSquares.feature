Feature:
	As a Customer
	I want to select one or two colours of Pockets Squares
	So that I can receive these Products as part of my Try-On

Background: 
	Given I am on the Xedo QuickTryOn page

Scenario: Customer adds a Pocket Square to Try-On
	Given the Try-On has less then two Pocket Squares
	When the Customer adds a Pocket Square
	Then the Pocket Square is added to the Try-On

Scenario: Customer attempts to add a Pocket Square to a Try-On containing the maximum number of Pocket Squares allowed
	Given the Try-On has the maximum number of Pocket Squares
	When the Customer adds a Pocket Square
	Then the Customer is informed of the maximum number of Pocket Squares
	And the new Pocket Square is not added to the Try-On

Scenario: Customer removes a Pocket Square from Try-On
	Given the Try-On has at least one Pocket Square
	When the Customer removes a Pocket Square
	Then the Pocket Square is removed from the Try-On

Scenario: Customer removes a Pocket Square from Try-On by re-selecting the Pocket Square colour
	Given the Try-On has at least one Pocket Square
	When the Customer removes a Pocket Square by re-selecting the Pocket Square colour
	Then the Pocket Square is removed from the Try-On

Scenario: Customer does not add any Pocket Squares
	Given the Try-On contains zero Pocket Squares
	When the Customer places the Try-On Order
	Then the Customer is informed that at least one Pocket Square is required

Scenario: Customer attempts to add the same Pocket Square twice
	Given the Try-On contains one Pocket Square
	When the Customer attempts to add the same Pocket Square to the Try-On
	Then the Pocket Square is not added to the Try-On twice