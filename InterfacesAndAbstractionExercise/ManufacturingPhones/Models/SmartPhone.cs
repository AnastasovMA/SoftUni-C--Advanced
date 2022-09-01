using System.Linq;

using ManufacturingPhones.Interfaces;
using ManufacturingPhones.InvalidExceptions;

namespace ManufacturingPhones.Models
{
    public class SmartPhone : ICalling, IBrowsing
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidUrlException();
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
