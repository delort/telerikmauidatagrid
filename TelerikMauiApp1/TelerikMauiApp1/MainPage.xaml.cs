using Telerik.Maui.Controls.Compatibility.Common.Data;
using Telerik.Maui.Controls.Compatibility.DataGrid;

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

        foreach (var column in dataGrid.Columns)
        {
            column.CanUserGroup = false;
        }

        dataGrid.UserGroupMode = DataGridUserGroupMode.Disabled;

    }
}