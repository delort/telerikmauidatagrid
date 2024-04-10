using Telerik.Maui.Controls.Compatibility.Common.Data;
using Telerik.Maui.Controls.Compatibility.DataGrid;

namespace TelerikMauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel();

        dataGrid.UserGroupMode = DataGridUserGroupMode.Disabled;
    }
}