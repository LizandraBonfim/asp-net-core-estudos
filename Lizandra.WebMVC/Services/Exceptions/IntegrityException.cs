using System;

namespace Lizandra.WebMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException (string message) : base(message){}
    }
}