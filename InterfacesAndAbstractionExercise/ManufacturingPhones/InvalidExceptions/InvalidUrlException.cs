using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingPhones.InvalidExceptions
{
    public class InvalidUrlException : Exception
    {
        private const string InvalidUrlExceptionMessage = "Invalid URL!";

        public InvalidUrlException()
            :base(InvalidUrlExceptionMessage)
        {

        }
    }
}
