Feature: labsession

feature to test registration and login

Background: 
	Given User is in Registration form
@Sanity 
Scenario: Verify Registration functionality
  When User enters the Credentials
  And User clicks on the register button
  Then User sees confirmation message

@Regression
Scenario Outline: Verify registration with test parameters
  When User enter first name "<firstName>", last name "<lastName>", address "<address>", city "<city>", state "<state>", zip code "<zipCode>", phone number "<phoneNumber>", SSN "<ssn>", username "<username>", and password "<password>"
  And User click on register button
  Then User see a confirmation message

Examples: 
  | firstName | lastName | address       | city       | state | zipCode | phoneNumber | ssn         | username | password   |
  | Alice     | Smith    | 456 Elm St    | Metropolis | NY    | 67890   | 555-6789    | 987-65-4321 | alices   | pass123    |
 






