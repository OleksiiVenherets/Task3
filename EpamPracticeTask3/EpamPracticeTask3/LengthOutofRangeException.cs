using System;
using System.Runtime.Serialization;

namespace EpamPracticeTask3
{
    /// <summary>
    /// Exception of index out of range 
    /// </summary>
    [Serializable]
    internal class LengthOutofRangeException : Exception
    {
        public LengthOutofRangeException()
        {
        }

        public LengthOutofRangeException(string message) : base(message)
        {
        }

        public LengthOutofRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LengthOutofRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}