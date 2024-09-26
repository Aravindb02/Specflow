Feature: OrangeHrm

Test orange hrm website login functionality


Scenario: Verify login for orange hrm website
	Given User is on orange hrm login page
	When User enters the "<username>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is navigated to the home page

Examples: 
	| username | passwd   |
	| Admin    | admin123 |




