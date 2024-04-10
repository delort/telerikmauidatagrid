namespace TelerikMauiApp1.Models;

public class GroupingAndSorting : IComparable
{
    public required DateTime ExpirationDate { get; init; }
    public required double Strike { get; init; }

    public override bool Equals(object obj)
    {
        if (obj is GroupingAndSorting other)
        {
            return ExpirationDate == other.ExpirationDate;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ExpirationDate.GetHashCode();
    }

    public int CompareTo(object obj)
    {
        if (obj is not GroupingAndSorting other)
        {
            return 1;
        }

        int sort = ExpirationDate.CompareTo(other.ExpirationDate);

        if (sort == 0)
        {
            sort = Strike.CompareTo(other.Strike);
        }

        return sort;
    }
}

public class ExpirationDate
{
    public required DateTime Value { get; init; }
}

public class OptionChainRow
{
    public GroupingAndSorting GroupAndSort { get; init; }

    // Underlying Equity
    public string Symbol { get; set; }
    public double Last { get; set; }

    public DateTime ExpirationDate => Expiration.Value;

    // Option Expiration and Strike
    public ExpirationDate Expiration { get; set; }
    public double Strike { get; set; }

    // Call Option Date
    public double CallLast { get; set; }
    public double CallChange { get; set; }
    public double CallBid { get; set; }
    public double CallAsk { get; set; }
    public double CallVolume { get; set; }
    public double CallOpenInterest { get; set; }

    // Put Option Data
    public double PutLast { get; set; }
    public double PutChange { get; set; }
    public double PutBid { get; set; }
    public double PutAsk { get; set; }
    public double PutVolume { get; set; }
    public double PutOpenInterest { get; set; }
}