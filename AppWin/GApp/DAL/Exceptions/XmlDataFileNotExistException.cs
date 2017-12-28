using System;
using System.Runtime.Serialization;

namespace GApp.DAL.Exceptions
{
    [Serializable]
    public class XmlDataFileNotExistException : Exception
    {
        public XmlDataFileNotExistException()
        {
        }

        public XmlDataFileNotExistException(string message) : base(message)
        {
        }

        public XmlDataFileNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected XmlDataFileNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}