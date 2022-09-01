namespace ManufacturingPhones.Models
{
    using System.Linq;
    using System;

    using ManufacturingPhones.Interfaces;
    using ManufacturingPhones.InvalidExceptions;
    public class StationaryPhone : ICalling
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}
