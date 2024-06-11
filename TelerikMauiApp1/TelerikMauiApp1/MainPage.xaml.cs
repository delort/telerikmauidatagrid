using Telerik.Maui.Controls.DataGrid;

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