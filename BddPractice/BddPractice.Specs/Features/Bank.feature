Feature: Bank account transfers

A short summary of the feature

@tag1
Scenario: Bob craves pizza and wants to transfer money from his salary account to his card account, pizza + soda costs 120 sek
	Given Salary account has 10532 sek
	And card account has 20 sek
	When He transfers money from salary acccount to card account
	Then card account should have 120 sek
	And salary account should have 10432 sek
