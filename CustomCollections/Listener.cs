﻿using CustomDatastructures.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class Listener
    {
        public void Subscribe<T>(ObservableList<T> list)
        {
            list.BeforeChange += List_BeforeChange;
            list.Changed += List_Changed;
        }

        private void List_BeforeChange<T>(object sender, RejectArgs<T> e)
        {
            bool checkValue = true;
            if (checkValue)
            {
                e.RejectOperation();
            }
        }

        private void List_Changed<T>(object sender, ListChangedEventArgs<T> e)
        {

        }
    }
}
