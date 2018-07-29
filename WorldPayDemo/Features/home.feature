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


Scenario: Fill Contact Us Form again	
	Given I navigate to worldpay website
	And I click Contact us link
	And I click Arrange a free call button
	Then I fill in form
	| name  | telephone   | email          |
	| test  | 07777777777 | test@test.com  |

@Current
Scenario: Select a sector	
	Given I navigate to worldpay website
	And I click Insights link
	And I click Worldpay Market Insights link
	And I switch to new window
	Then I select below Sector:
	| sector  | 
	| Art & Leisure  |
	Then I close the browser




