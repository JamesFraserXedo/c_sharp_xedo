Feature: Home Page Load Time
	

Scenario Outline: First time home page loads in good time
	Given I am on the <Site> OutfitBuilder page
	When I go to the <Site> <Page> page
	Then the page load time will be less than <Timeout> seconds

	Examples:
	| Site            | Page          | Timeout |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |

Scenario Outline: Subsequent home page loads in good time
	Given I am on the <Site> <Page> page
	When I go to the <Site> <Page> page
	Then the page load time will be less than <Timeout> seconds

	Examples:
	| Site            | Page          | Timeout |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |
	| XedoPerformance | Home          | 3       |