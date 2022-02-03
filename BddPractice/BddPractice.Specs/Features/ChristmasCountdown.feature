Feature: Christmas Countdown

Feature for counting down the days until next Xmas

@tag1
Scenario: Max is a christmas fanatic and longs for xmas and winter, he wants to know how many days there are from today til xmas (24 dec) 2022.
	Given Todays date is 2022-01-25
	And Todays date is before xmas this year
	When He inputs todays date into the method
	Then He should get the correct number of days until december 24, 2022 (333)
