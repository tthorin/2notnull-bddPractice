using BddPracticeLib;
using System;
using TechTalk.SpecFlow;

namespace BddPractice.Specs.StepDefinitions
{
    [Binding]
    public class JunkFoodTrackerStepDefinitions
    {
        private readonly JunkFoodTracker junkFood2021 = new();
        DateTime date;
        string response = "";

        [Given(@"the date is (\d{4})-(\d\d)-(\d\d)")]
        public void GivenTheDateIs(int year, int month, int day)
        {
            date = new DateTime(year, month, day);
        }

        [Given(@"He has bought (\d+) pizzas this month")]
        public void GivenHeHasBoughtPizzasThisMonth(int pizza)
        {
            var pizzaBought = pizza > 0;
            junkFood2021.RegisterJunkFoodBought(date, 0, pizzaBought);
        }
        
        [Given(@"He has spent (\d+) kr on.*")]
        public void GivenHeSpentKrOnBurgersForHimselfAndHisFriendOnTheWayToTheParty(int earlierSpendings)
        {
            junkFood2021.RegisterJunkFoodBought(date,earlierSpendings);
        }


        [When(@"he asks the program if he may buy junk food \((\d+) pizzas?\) for (\d+) kr today")]
        public void WhenHeAsksTheProgramIfHeMayBuyAPizzaToday(int pizzas,int price)
        {

            var buyingPizza = pizzas > 0;
            response = junkFood2021.RegisterJunkFoodBought(date, price, buyingPizza);
        }

        [Then(@"the program responds with ""(.*)""")]
        public void ThenTheProgramRespondsWith(string expectedResponse)
        {
            response.Should().Be(expectedResponse);
        }
    }
}
