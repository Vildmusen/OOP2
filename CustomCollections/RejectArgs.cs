using CustomDatastructures.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class RejectArgs<T> : RejectableEventArgs<T>
    {
        private bool isRejected = false;

        public RejectArgs(Operation operation, T value, int count) : base(operation, value, count) { }

        public override bool IsOperationRejected => isRejected;

        public override void RejectOperation()
        {
            isRejected = true;
        }
    }
}
