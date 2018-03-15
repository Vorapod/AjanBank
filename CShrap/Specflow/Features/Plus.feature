Feature: SpecFlowFeature1
	As a user
	I want to be told the plus of two numbers
	So that the result should be correct

Scenario: Caculator process Plus
	Given I have entered 50 into the calculator of Value1
	And I have entered 70 into the calculator of Value2
	When I "Plus"
	Then the result should be 120
