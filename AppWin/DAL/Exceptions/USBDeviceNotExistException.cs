using System;
using System.Runtime.Serialization;

namespace TP_Tracking.Exceptions
{
    [Serializable]
    public class USBDeviceNotExistException : Exception
    {
        public USBDeviceNotExistException()
        {
        }

        public USBDeviceNotExistException(string message) : base(message)
        {
        }

        public USBDeviceNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected USBDeviceNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}