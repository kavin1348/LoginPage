Feature: Login
	In order to test login page
	I want to automate the common login scenarios

  Scenario: Verify Login page isloaded
	Given I open the login page
	Then I should see the login button

  Scenario: verify login successful with valid credentials
	Given I open the login page
	When I enter text "testuser" into "username" field
	And I enter text "Password123" into "password" field
	And I press the "Log in" button
	Then I should see the "library" page
	
Scenario: validate login fields
	Given I open the login page
	When I press the "Log in" button
	Then I should see "username" field highlighted in red
	And I should see "username" field highlighted in red
	
Scenario: verify login unsuccesful with invalid credentials
	Given I open the login page
	When I enter text "user@test.com" into "username" field
	And I enter text "123456" into "password" field
	And I press the "Log in" button
	Then I should see "Wrong email or password." error message
	
Scenario: verify password reset option
	Given I open the login page
	When I click on "Forgot your password?" link
	Then I should see the email field
	And I should see the send button

Scenario: verify upcoming products section in library page
	Given I open the library page
	Then I should see the "Upcoming products" section in the page