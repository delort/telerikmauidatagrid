using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using TelerikMauiApp1.Models;

namespace TelerikMauiApp1;

public class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        OptionChain = new ObservableCollection<OptionChainRow>();
 
        Task.Run(async () =>
        {
            await Task.Delay(5000);

            var optionChain = MockOptionChain.GetOptionChain();

            foreach (var option in optionChain)
            {
                OptionChain.Add(option);
            }
        });
    }
    
    public ObservableCollection<OptionChainRow> OptionChain { get; }
}