Feature: JunkFoodTracker

Simple function for tracking amount of junkfood bought and making sure the user doesnt buy for more than 500 sek and or
	buys pizza more then once a month

Scenario: Johan would like to buy a pizza late in a month where he's been a good boy and haven't spent alot on
	junk food or bought any pizzas
	
	Given the date is 2021-08-27
	And He has bought 0 pizzas this month
	And He has spent 55 kr on churros earlier in the month at the annual Food & Culture fair
	When he asks the program if he may buy junk food (1 pizza) for 120 kr today
	Then the program responds with "OK. 325 kr left to spend this month."

Scenario: In september, Johan goes to a party with some friends, on his way there he buys burgers for himself and a
	friend, and the morning after he oddly enough wants to buy himself and his unnamed nightly pizza for breakfast so
	he checks his program.
	
	Given the date is 2021-09-21
	And He has bought 0 pizzas this month
	And He has spent 220 kr on burgers for himself and his friend on the way to the party
	When he asks the program if he may buy junk food (2 pizzas) for 240 kr today
	Then the program responds with "OK. 40 kr left to spend this month."

Scenario: In october, Johan wants to buy a pizza but he has already bought a pizza ealier in the month, against all
	hope, he still asks his program if he may buy a pizza
	
	Given the date is 2021-10-12
	And He has bought 1 pizza this month
	And He has spent 120 kr on the pizza
	When he asks the program if he may buy junk food (1 pizza) for 120 kr today
	Then the program responds with "Denied. Already bought pizza this month."

Scenario: In november, Johan has been feeling tired and fallen back on his bad habits of eating too much junk food,
	at the end of the month, he really wants to buy some burgers but is not sure if he has enough money so he asks
	his program
	
	Given the date is 2021-11-28
	And He has spent 450 kr on junk food earlier in the month
	When he asks the program if he may buy junk food (0 pizza) for 100 kr today
	Then the program responds with "Denied. Not enough funds. (50 kr missing)."