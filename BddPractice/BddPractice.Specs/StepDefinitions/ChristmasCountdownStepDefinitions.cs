namespace BddPractice.Specs.StepDefinitions;

using BddPracticeLib;

[Binding]
public class ChristmasCountdownStepDefinitions
{
    private DateTime date;
    private int result;
    private bool dateIsBeforeXmas;

    [Given(@"Todays date is (\d{4})-(\d\d)-(\d\d)")]
    public void GivenTodaysDateIs(int year, int month, int day) => date = new DateTime(year, month, day);

    [Given("Todays date is before xmas this year")]
    public void GivenTodaysDateIsBeforeXmasThisYear() => dateIsBeforeXmas = date < new DateTime(DateTime.Now.Year, 12, 24);

    [When("He inputs todays date into the method")]
    public void WhenHeInputsTodaysDateIntoTheMethod() => result = dateIsBeforeXmas ? XmasCountdown.DaysUntilXmas(date) : -1;

    [Then(@"He should get the correct number of days until december 24, 2022 \((.*)\)")]
    public void ThenHeShouldGetTheCorrectNumberOfDaysUntilDecember(int days) => result.Should().Be(days);
}
