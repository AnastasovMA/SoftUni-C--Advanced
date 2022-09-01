﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string Invalid_URL_Exception = "Invalid URL!";
        public InvalidURLException()
            :base(Invalid_URL_Exception)
        {

        }
    }
}
