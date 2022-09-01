namespace _03.Telephony.Models
{
    using _03.Telephony.Interfaces;
    using System.Linq;
    using _03.Telephony.Exceptions;
    public class StationaryPhone : ICalling
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x))) // if one of these is not a digit, we go to the exception
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}
