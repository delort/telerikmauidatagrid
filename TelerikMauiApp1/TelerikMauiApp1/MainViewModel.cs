using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Telerik.Maui.Controls;
using Telerik.Maui.Controls.Data;
using Telerik.Maui.Controls.DataGrid;
using Telerik.UI.Xaml.Controls.Grid.Primitives;
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
    
    public RelayCommand<RadDataGrid> NextLayout => new((dg) =>
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            int numColumns = dg.Columns.Count;

            dg.Columns.Clear();
            dg.Columns.Add(new DataGridTextColumn { PropertyName = "Symbol", SizeMode = DataGridColumnSizeMode.Fixed });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "Last" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "Strike" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallLast" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallChange" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallBid" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallAsk" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallVolume" });
            dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "CallOpenInterest" });

            if (numColumns != 15)
            {
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutLast" });
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutChange" });
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutBid" });
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutAsk" });
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutVolume" });
                dg.Columns.Add(new DataGridNumericalColumn { PropertyName = "PutOpenInterest" });
            }


            dg.GroupDescriptors.Clear();
            dg.GroupDescriptors.Add(new PropertyGroupDescriptor() { PropertyName = "GroupAndSort"});

            dg.SortDescriptors.Clear();
            dg.SortDescriptors.Add(new PropertySortDescriptor() { PropertyName = "GroupAndSort" });
        });
    });

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