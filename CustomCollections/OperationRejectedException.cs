using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    /// <summary>
    /// Custom exception to be thrown is subscriber wants to deny an operation.
    /// </summary>
    public class OperationRejectedException : InvalidOperationException
    {
        public OperationRejectedException()
        {

        }

        public OperationRejectedException (string message):base (message)
        {

        }
    }
}
