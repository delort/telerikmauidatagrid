using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    
    public RelayCommand Refresh => new(() =>
    {
        Task.Run(async () =>
        {
            await Task.Delay(5000);

            var optionChain = MockOptionChain.GetOptionChain();

            // Simulate a change in the data
            foreach (var option in OptionChain.ToList())
            {
                OptionChain.Remove(option);
            }

            foreach (var option in optionChain)
            {
                OptionChain.Add(option);
            }
        });
    });

    public ObservableCollection<OptionChainRow> OptionChain { get; }
}