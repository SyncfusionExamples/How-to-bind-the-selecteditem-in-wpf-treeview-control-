﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewAdv
{
    public class Model
    {
        public Model()
        {
            SubItems = new ObservableCollection<Model>();
        }

        public string Header { get; set; }

        public ObservableCollection<Model> SubItems { get; set; }
    }    
}


