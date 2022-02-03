namespace BddPracticeLib;

public static class XmasCountdown
{
    public static int DaysUntilXmas(DateTime from=default)
    {
        if (from == default) from = DateTime.Now;
        var thisYear = DateTime.Now.Year;
        if (from.Year == thisYear && from.Month == 12 && from.Day > 24) thisYear++;
        var xmas = new DateTime(thisYear, 12, 24);
        return (xmas - from).Days;
    }
}
