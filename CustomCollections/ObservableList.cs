﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDatastructures.Core;

namespace CustomCollections
{

    public class ObservableList<T> : IEnumerable<T>, IObservable<T>
    {
        private RejectArgs<T> args;
        private List<T> internalList;
        public event EventHandler<RejectArgs<T>> BeforeChange;
        public event EventHandler<ListChangedEventArgs<T>> Changed;

        public ObservableList()
        {
            internalList = new List<T>();
        }

        public void Add(T item)
        {
            SendBeforeChangeEvent(Operation.Add, item);
            
            if (!args.IsOperationRejected)
            {
                internalList.Add(item);
                Changed?.Invoke(this, new ListChangedEventArgs<T>(Operation.Add, item, internalList.Count));
            }
        }


        public void Remove(T item)
        {
            SendBeforeChangeEvent(Operation.Remove, item);

            if (!args.IsOperationRejected && internalList != null)
            {
                internalList.Remove(item);
                Changed?.Invoke(this, new ListChangedEventArgs<T>(Operation.Remove, item, internalList.Count));
            }

        }
        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }

        private void SendBeforeChangeEvent(Operation op, T item)
        {
            args = new RejectArgs<T>(op, item, internalList.Count);
            BeforeChange?.Invoke(this, args);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)internalList).GetEnumerator();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }
    }
}
