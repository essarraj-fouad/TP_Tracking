using System;
using System.Runtime.Serialization;

namespace TP_Tracking.DAL.Tests
{
    [Serializable]
    internal class ConfigurationFileNotExistException : Exception
    {
        public ConfigurationFileNotExistException()
        {
        }

        public ConfigurationFileNotExistException(string message) : base(message)
        {
        }

        public ConfigurationFileNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConfigurationFileNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}