using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDatastructures.Core;

namespace CustomCollections
{
    // Make this class generic by adding a type-parameter to the class
     //public delegate bool BeforeChange();
    private deletagate void Eventhandler<TEventArgs>();
    public class ObservableList<T> : IEnumerable<T>
    {
        // Declare an private variable, internalList, to work as 
        // the internal data storage for the list
        private List<T> internalList;
        event EventHandler<ObservableList<T>> BeforeEvent;
        public ObservableList()
        {
            internalList = new List<T>();
        }
        public void Add(T item)
        {
            //this.beforeEvent += new EventHandler(this.internalList);
            internalList.Add(item);

        }
        public void Remove(T item)
        {
            if (internalList != null)
            {
                internalList.Remove(item);
            }
        }
        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)internalList).GetEnumerator();
        }


    }
}
