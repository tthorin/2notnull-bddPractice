namespace BddPracticeLib;

public class JunkFoodTracker
{
    private readonly int[] monthlyAllowance = new int[] { 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 };
    private readonly bool[] pizzaBoughtThisMonth = new bool[12];

    public string RegisterJunkFoodBought(DateTime date,int amount, bool isPizza=false)
    {
        var adjustedMonth = date.Month - 1;
        if (amount > monthlyAllowance[adjustedMonth]) return $"Denied. Not enough funds. ({amount - monthlyAllowance[adjustedMonth]} kr missing).";
        else if (isPizza && pizzaBoughtThisMonth[adjustedMonth]) return "Denied. Already bought pizza this month.";

        if(isPizza) pizzaBoughtThisMonth[adjustedMonth] = true;
        monthlyAllowance[adjustedMonth] -= amount;
        return $"OK. {monthlyAllowance[adjustedMonth]} kr left to spend this month.";
    }
}
