using BddPracticeLib;

namespace BddPractice.Specs.StepDefinitions
{
    [Binding]
    public class JunkFoodTrackerStepDefinitions
    {
        private readonly JunkFoodTracker _junkFood2021 = new();
        private DateTime _date;
        private string _response = "";

        [Given(@"the date is (\d{4})-(\d\d)-(\d\d)")]
        public void GivenTheDateIs(int year, int month, int day)
        {
            _date = new DateTime(year, month, day);
        }

        [Given(@"He has bought (\d+) pizzas? this month")]
        public void GivenHeHasBoughtPizzasThisMonth(int pizza)
        {
            var pizzaBought = pizza > 0;
            _junkFood2021.RegisterJunkFoodBought(_date, 0, pizzaBought);
        }
        
        [Given(@"He has spent (\d+) kr on.*")]
        public void GivenHeSpentKrOnBurgersForHimselfAndHisFriendOnTheWayToTheParty(int earlierSpendings)
        {
            _junkFood2021.RegisterJunkFoodBought(_date,earlierSpendings);
        }


        [When(@"he asks the program if he may buy junk food \((\d+) pizzas?\) for (\d+) kr today")]
        public void WhenHeAsksTheProgramIfHeMayBuyAPizzaToday(int pizzas,int price)
        {

            var buyingPizza = pizzas > 0;
            _response = _junkFood2021.RegisterJunkFoodBought(_date, price, buyingPizza);
        }

        [Then(@"the program responds with ""(.*)""")]
        public void ThenTheProgramRespondsWith(string expectedResponse)
        {
            _response.Should()?.Be(expectedResponse);
        }
    }
}
