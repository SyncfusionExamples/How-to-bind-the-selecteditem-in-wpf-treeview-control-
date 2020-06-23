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

        public object SelectedItem { get; set; }

        public ViewModel()
        {
            TreeItems = PopulateData();
            SelectedItem = TreeItems[1];
        }

        private ObservableCollection<Model> PopulateData()
        {
            TreeItems =new ObservableCollection<Model>();
            TreeItems.Add(new Model() { Header = "Mailbox" });
            TreeItems.Add(new Model() { Header = "Calendar" });
            TreeItems.Add(new Model() { Header = "Contacts" });
            TreeItems.Add(new Model() { Header = "Drafts" });
            TreeItems.Add(new Model() { Header = "Parent1" });
            return TreeItems;
        }
    }
}
