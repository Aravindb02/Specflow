Feature: Test Login functionality

feature to test login functionality


Scenario: verify Login functionality
	Given User is on Login page
	When User enters username and password
	And User clicks on login button
	Then User is navigated to home page
