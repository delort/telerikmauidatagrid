using CommunityToolkit.Mvvm.ComponentModel;
using TelerikMauiApp1.Models;

namespace TelerikMauiApp1;

public class MainViewModel : ObservableObject
{
    public IReadOnlyCollection<OptionChainRow> OptionChain { get; } = MockOptionChain.GetOptionChain();
}