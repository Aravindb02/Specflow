Feature: InavalidOrangeHRM

Testing for invalid credentials while loging in

@tag1
Scenario: Verify invalid login for orange hrm website
	Given User is on the orange hrm login page
	When User enters "<username>" and "<passwd>" in the text fields
	When User clicks submit button
	Then User gets error message

Examples: 
	| username | passwd   |
	| Adminnn  | admi2223 |
