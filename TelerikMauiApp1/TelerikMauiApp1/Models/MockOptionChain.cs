using System.Runtime.InteropServices.JavaScript;

namespace TelerikMauiApp1.Models;

public static class MockOptionChain
{
    public static IReadOnlyCollection<OptionChainRow> GetOptionChain()
    {
        List<OptionChainRow> optionChain = new();

        DateTime now = DateTime.Now.Date;
        DateTime startDate = new DateTime(now.Year, now.Month == 12 ? 1 : now.Month + 1, 1);

        // do this for 72 weeks
        for (int i = 0; i < 72; i++)
        {
            DateTime weekDate = startDate.AddDays(i * 7);

            optionChain.AddRange(GetOptionChainByDate(weekDate.Year, weekDate.Month, weekDate.Day));
        }

        return optionChain;
    }

    public static IReadOnlyCollection<OptionChainRow> GetOptionChainByDate(int year, int month, int day)
    {
        DateTime expirationDate = new(year, month, day);

        List<OptionChainRow> optionChain = new();

        Random rnd = new();
        double strike = rnd.Next(120, 190) * 1.0;

        for (int i = 0; i < 150; i++)
        {
            var strikevalue = strike + i * 5.0;

            var row = new OptionChainRow
            {
                GroupAndSort = new GroupingAndSorting { ExpirationDate = expirationDate, Strike = strikevalue },
                Symbol = "AAPL",
                Last = 350.51,
                Expiration = new ExpirationDate { Value = expirationDate },
                Strike = strikevalue,
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
            };

            optionChain.Add(row);
        }

        return optionChain;
    }
}