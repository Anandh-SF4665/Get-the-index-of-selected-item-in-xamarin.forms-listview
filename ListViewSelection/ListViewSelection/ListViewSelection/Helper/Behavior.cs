using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SelectionItemIndex
{
   public class Behavior : Behavior<ContentPage>
    {
        SfListView ListView; Entry Entry;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            Entry = bindable.FindByName<Entry>("entry");
            ListView.SelectionChanged += ListView_SelectionChanged;
            base.OnAttachedTo(bindable);
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

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            ListView.SelectionChanged -= ListView_SelectionChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}
