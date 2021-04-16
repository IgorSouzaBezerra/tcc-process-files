using System;

namespace ProcessFile.API.Error
{
    public class ServiceException : Exception
    {
        public ServiceException(string message) : base(message)
        {}
    }
}