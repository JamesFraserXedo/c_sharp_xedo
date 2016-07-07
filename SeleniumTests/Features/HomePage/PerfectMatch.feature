Feature: PerfectMatch

Scenario Outline: Perfect Match redirects to correct outfit builder tab
	Given I am on the Xedo Home page
	When I select the perfect match colour <colour>
	Then I am on the Xedo OutfitBuilder page
	And the neckwear filter is expanded
	And the colour <colour> filter is selected

	Examples: 
	| colour |
	| black  |
	| teal   |
	| blue	 |
	| green  |
	| purple |
	| grey	 |
	| red	 |
	| tan	 |
	| pink	 |
	| yellow |
	| ivory	 |
