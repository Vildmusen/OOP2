using CustomDatastructures.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class Listener
    {
        public bool isRejecting = false;

        public void Subscribe<T>(ObservableList<T> list)
        {
            list.BeforeChange += List_BeforeChange;
            list.Changed += List_Changed;
        }

        private void List_BeforeChange<T>(object sender, RejectArgs<T> e)
        {
<<<<<<< HEAD
            bool checkValue = false;
            if (checkValue)
=======
            if (isRejecting)
>>>>>>> fe8f5d8b1dbcf7e1e21f9a1bc5f6e23e167f60a0
            {
                e.RejectOperation();
            }
        }

        private void List_Changed<T>(object sender, ListChangedEventArgs<T> e)
        {

        }
    }
}
