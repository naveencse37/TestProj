Feature: HomePage

Scenario: verify about worldpay text

	Given I navigate to worldpay website
	And I click Company link
	And I verify About Worldpay text
	Then I close the browser


Scenario Outline: Fill Contact Us Form
	
	Given I navigate to worldpay website
	And I click Contact us link
	And I click Arrange a free call button
	Then I fill form <name>, <telephone>, <email>

Examples:
| name   | telephone | email |
| test | 077777777777|    test@test.com   |

@Current
Scenario: Fill Contact Us Form again	
	Given I navigate to worldpay website
	And I click Contact us link
	And I click Arrange a free call button
	Then I fill in form
	| name  | telephone   | email          |
	| test  | 07777777777 | test@test.com  |
	Then I close the browser
