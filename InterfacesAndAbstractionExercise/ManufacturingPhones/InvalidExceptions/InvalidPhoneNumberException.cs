using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingPhones.InvalidExceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string InvalidPhoneNumber = "Invalid number!";

        public InvalidPhoneNumberException()
            :base(InvalidPhoneNumber)
        {

        }
    }
}
