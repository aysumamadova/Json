using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Exceptions
{
    class Ex
    {
        public class NotAvailableException : Exception
        {
            public NotAvailableException(string message) : base(message) { }
        }

        public class NullEmptyWhiteSpaceException : Exception
        {
            public NullEmptyWhiteSpaceException(string message) : base(message) { }
        }
    }
}

