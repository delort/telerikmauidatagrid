using Telerik.Maui.Controls.Compatibility.Common.Data;
using TelerikMauiApp1.Models;

namespace TelerikMauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel();

        PropertyGroupDescriptor groupDescriptor = new()
        {
            PropertyName = "ExpirationDate"
        };

        dataGrid.GroupDescriptors.Add(groupDescriptor);
    }
}