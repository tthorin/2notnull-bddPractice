using BddPracticeLib;
using System;
using TechTalk.SpecFlow;

namespace BddPractice.Specs.StepDefinitions
{
    [Binding]
    public class ChristmasCountdownStepDefinitions
    {
        DateTime date;
        int result;
        bool dateIsBeforeXmas = false;

        [Given(@"Todays date is (\d{4})-(\d\d)-(\d\d)")]
        public void GivenTodaysDateIs(int year,int month, int day)
        {
            date = new DateTime(year, month, day);
        }

        [Given(@"Todays date is before xmas this year")]
        public void GivenTodaysDateIsBeforeXmasThisYear()
        {
            dateIsBeforeXmas = date < new DateTime(DateTime.Now.Year, 12, 24);
        }

        [When(@"He inputs todays date into the method")]
        public void WhenHeInputsTodaysDateIntoTheMethod()
        {
            result = XmasCountdown.DaysUntilXmas(date);
        }


        [Then(@"He should get the correct number of days until december 24, 2022 \((.*)\)")]
        public void ThenHeShouldGetTheCorrectNumberOfDaysUntilDecember(int days)
        {
            result.Should().Be(days);
        }
    }
}
