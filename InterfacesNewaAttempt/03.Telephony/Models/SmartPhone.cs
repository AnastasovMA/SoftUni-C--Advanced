

namespace _03.Telephony.Models
{
    using _03.Telephony.Interfaces;
    using System.Linq;
    using _03.Telephony.Exceptions;
    public class SmartPhone : IBrowse, ICalling
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
