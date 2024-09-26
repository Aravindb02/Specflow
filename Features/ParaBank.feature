Feature: ParaBank

feature to test registration and login

Background: 
	Given User is in  Registration form



Scenario Outline: Verify registration with test parameters
  When User enters the first name "<firstName>", last name "<lastName>", address "<address>", city "<city>", state "<state>", zip code "<zipCode>", phone number "<phoneNumber>", SSN "<ssn>", username "<username>", and password "<password>" confirm "<confirm>"
  And User clicks on  register button
  Then User see a  confirmation message

Examples: 
  | firstName | lastName | address    | city       | state | zipCode | phoneNumber | ssn         | username | password | confirm |
  | Alice     | Smith    | 456 Elm St | Metropolis | NY    | 67890   | 555-6789    | 987-65-4321 | alices   | pass123  | pass123 |

