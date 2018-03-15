Feature: SpecFlowFeature1
	As a user
	I want to be told the plus of two numbers
	So that the result should be correct

@mytag
Scenario: Caculator process Plus
	Given I have entered 50 into the calculator of Value1
	And I have entered 70 into the calculator of Value2
	When I "Plus"
	Then the result should be 120

Scenario Outline: Caculator process Plus by Excel
	Given I have entered values from excel into the calculator
	| Value1   | Value2   |
	| <value1> | <value2> |
	When I "Plus"
	Then the result should be 120

@source:Calculator.xlsx:Plus
Examples:
	| value1 | value2 | result |

