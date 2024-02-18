namespace TelerikMauiApp1.Models;

public class OptionChainRow
{
    // Underlying Equity
    public string Symbol { get; set; }
    public double Last { get; set; }

    // Option Expiration and Strike
    public DateTime ExpirationDate { get; set; }
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