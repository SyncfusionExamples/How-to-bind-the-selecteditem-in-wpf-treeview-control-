using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewAdv
{
    public class ViewModel 
    {
        public ObservableCollection<Model> TreeItems { get; set; }

        public object SelectedTreeItem { get; set; }

        public ViewModel()
        {
            TreeItems = PopulateData();
            SelectedTreeItem = TreeItems[1];
        }

        private ObservableCollection<Model> PopulateData()
        {
            TreeItems =new ObservableCollection<Model>();
            Model Root1 = new Model() { Header = "Parent1" };
            PopulateSubItems(Root1);
            TreeItems.Add(Root1);
            Model Root2 = new Model() { Header = "Parent2" };
            PopulateSubItems(Root2);
            TreeItems.Add(Root2);
            Model Root3 = new Model() { Header = "Parent3" };
            PopulateSubItems(Root3);
            TreeItems.Add(Root3);
            return TreeItems;
        }

        private void PopulateSubItems(Model Root)
        {
            Model SubItem1 = new Model() { Header = " Item1" };
            Model SubItem2 = new Model() { Header = " Item2" };
            Model SubItem3 = new Model() { Header = " Item3" };
            Model SubItem4 = new Model() { Header = " Item4" };
            Root.SubItems.Add(SubItem1);
            Root.SubItems.Add(SubItem2);
            Root.SubItems.Add(SubItem3);
            Root.SubItems.Add(SubItem4);
        }
    }
}

