@Smoke
Feature: TestLoginwithParams

Test Login with data parameters

Background: 
	Given User is on Login page

@Sanity@Regression
Scenario: verify Login functionality
	When User enters username and password
	And User clicks on login button
	Then User is navigated to home page


@Regression
Scenario Outline: Verify login with test parameters
	When User enters the "<username>" and "<password>"
	And User clicks on login button
	Then User is navigated to home page
	Then User selected city and country information
	| city  | country |
	| Delhi | India   |
	| Ohio  | USA     |
	

Examples: 

| username | password |
| tom      | Harry    |
| Jerry    | Mathew   |