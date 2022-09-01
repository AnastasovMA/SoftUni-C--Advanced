using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string Invalid_Phone_Number_Exception = "Invalid number!";
        public InvalidPhoneNumberException()
            :base(Invalid_Phone_Number_Exception)
        {

        }
    }
}
