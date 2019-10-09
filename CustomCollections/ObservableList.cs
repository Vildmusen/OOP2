using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDatastructures.Core;

namespace CustomCollections
{
    /// <summary>
    /// Implementation of generic list with add, tryadd, remove, tryremove and contians.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableList<T> : IEnumerable<T>, IObservable<T>, IObservableList<T>
    {
        private RejectArgs<T> args;
        private List<T> internalList;
        public event EventHandler<RejectableEventArgs<T>> BeforeChange;
        public event EventHandler<ListChangedEventArgs<T>> Changed;

        public ObservableList()
        {
            internalList = new List<T>();
        }

        /// <summary>
        /// Tries to add an item of type T to the list. 
        /// </summary>
        /// <param name="item">item to perform operation with</param>
        /// <returns>Returns true if succesful and false if unsuccesful.</returns>
        public bool TryAdd(T item)
        {
            try
            {
                Add(item);
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tries to add an item of type T to the list. Throws exception "OperationRejectedException" if rejected.
        /// </summary>
        /// <param name="item">item to perform operation with</param>
        public void Add(T item)
        {
            SendBeforeChangeEvent(Operation.Add, item);

            if (!args.IsOperationRejected)
            {
                internalList.Add(item);
                Changed?.Invoke(this, new ListChangedEventArgs<T>(Operation.Add, item, internalList.Count));
            }
            else
            {
                throw new OperationRejectedException("Add was rejected");
            }
        }

        /// <summary>
        /// Tries to remove an item of type T from the list.
        /// </summary>
        /// <param name="item">item to perform operation with</param>
        /// <returns>Returns true if succesful and false if unsuccesful.</returns>
        public bool TryRemove(T item)
        {
            try
            {
                Remove(item);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tries to removes an item of type T from the list. Throws exception "OperationRejectedException" if rejected.
        /// </summary>
        /// <param name="item">item to perform operation with</param>
        public void Remove(T item)
        {
            SendBeforeChangeEvent(Operation.Remove, item);

            if (!args.IsOperationRejected)
            {
                if (Contains(item))
                {
                    internalList.Remove(item);
                    Changed?.Invoke(this, new ListChangedEventArgs<T>(Operation.Remove, item, internalList.Count));
                }
                else
                {
                    throw new InvalidOperationException(item + " was not found in the list");
                }
            }
            else
            {
                throw new OperationRejectedException("Remove was rejected");
            }

        }

        /// <summary>
        /// Checks if item of type T i is the list.
        /// </summary>
        /// <param name="item">item to perform operation with</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }

        /// <summary>
        /// Invokes the event BeforeChange after modifiyng its argument "args" with the appropriate information.
        /// </summary>
        /// <param name="op">Operation to use.</param>
        /// <param name="item">item to be used with operation.</param>
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
