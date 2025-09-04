# Get the index of selected items

Getting the index of the selected items using the [SfListView.SelectedItems](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectedItems.html) of the underlying collections.

## Sample

```xaml
<StackLayout>
    <Entry x:Name="entry" HorizontalTextAlignment="Center"/>
    <sync:SfListView x:Name="listView" ItemsSource="{Binding ContactsInfo}" SelectionMode="Single">
        <sync:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition/>
                        <RowDefinition/>
                    </Grid.RowDefinitions>
                    <Label Text="{Binding ContactName}" Grid.Row="0"/>
                    <Label Text="{Binding ContactNumber}" Grid.Row="1"/>
                </Grid>
            </DataTemplate>
        </sync:SfListView.ItemTemplate>
    </sync:SfListView>
</StackLayout>
```

```
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
  }

  private void ListView_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
  {
      var items = e.AddedItems;
      for (int i = 0; items.Count > i; i++)
      {
          var index = ListView.DataSource.DisplayItems.IndexOf(items[i]);
          Entry.Text = index.ToString();
      }
  }
}
```

To know more about the Selection in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/selection)