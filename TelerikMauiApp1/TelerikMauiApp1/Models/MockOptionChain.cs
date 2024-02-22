namespace TelerikMauiApp1.Models;

public static class MockOptionChain
{
    public static IReadOnlyCollection<OptionChainRow> GetOptionChain()
    {
        List<OptionChainRow> optionChain = new();

        optionChain.AddRange(GetOptionChainByDate(2024, 03, 21));
        optionChain.AddRange(GetOptionChainByDate(2024, 04, 21));
        optionChain.AddRange(GetOptionChainByDate(2024, 05, 21));
        optionChain.AddRange(GetOptionChainByDate(2024, 06, 21));

        return optionChain;
    }

    public static IReadOnlyCollection<OptionChainRow> GetOptionChainByDate(int year, int month, int day)
    {
        DateTime expirationDate = new(year, month, day);

        List<OptionChainRow> optionChain = new()
        {
            new OptionChainRow
            {
                Symbol = "AAPL",
                Last = 145.86,
                Expiration = new ExpirationDate { Value = expirationDate }, 
                Strike = 145,
                CallLast = 0.01,
                CallChange = 0,
                CallBid = 0,
                CallAsk = 0,
                CallVolume = 0,
                CallOpenInterest = 0,
                PutLast = 0.01,
                PutChange = 0,
                PutBid = 0,
                PutAsk = 0,
                PutVolume = 0,
                PutOpenInterest = 0
            },
            new OptionChainRow
            {
                Symbol = "AAPL",
                Last = 145.86,
                Expiration = new ExpirationDate { Value = expirationDate },
                Strike = 150,
                CallLast = 0.01,
                CallChange = 0,
                CallBid = 0,
                CallAsk = 0,
                CallVolume = 0,
                CallOpenInterest = 0,
                PutLast = 0.01,
                PutChange = 0,
                PutBid = 0,
                PutAsk = 0,
                PutVolume = 0,
                PutOpenInterest = 0
            },
            new OptionChainRow
            {
                Symbol = "AAPL",
                Last = 145.86,
                Expiration = new ExpirationDate { Value = expirationDate },
                Strike = 155,
                CallLast = 0.01,
                CallChange = 0,
                CallBid = 0,
                CallAsk = 0,
                CallVolume = 0,
                CallOpenInterest = 0,
                PutLast = 0.01,
                PutChange = 0,
                PutBid = 0,
                PutAsk = 0,
                PutVolume = 0,
                PutOpenInterest = 0
            },
            new OptionChainRow
            {
                Symbol = "AAPL",
                Last = 145.86,
                Expiration = new ExpirationDate { Value = expirationDate },
                Strike = 155,
                CallLast = 0.01,
                CallChange = 0,
                CallBid = 0,
                CallAsk = 0,
                CallVolume = 0,
                CallOpenInterest = 0,
                PutLast = 0.01,
                PutChange = 0,
                PutBid = 0,
                PutAsk = 0,
                PutVolume = 0,
                PutOpenInterest = 0
            }
        };

        return optionChain;
    }
}