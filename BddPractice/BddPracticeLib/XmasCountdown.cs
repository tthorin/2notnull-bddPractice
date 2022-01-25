namespace BddPracticeLib;

public static class XmasCountdown
{
    public static int DaysUntilXmas(DateTime from)
    {
        var thisYear = DateTime.Now.Year;
        if (from.Year == thisYear && from.Month == 12 && from.Day > 24) thisYear++;
        var xmas = new DateTime(thisYear, 12, 24);
        var daysTilXmas = xmas - from;
        return daysTilXmas.Days;
    }
}
