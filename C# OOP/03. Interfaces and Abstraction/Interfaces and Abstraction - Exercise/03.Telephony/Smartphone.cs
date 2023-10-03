using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : IPhone, ISmartphone
    {
        public Smartphone()
        {
            
        }

        public string Call(string phoneNumber)
        {
            if(!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentNullException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }

        public string Browse(string site)
        {
            if(!ValidateUrl(site))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {site}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }

        private bool ValidateUrl(string url)
        {
            return url.All(c => !char.IsDigit(c));
        }
    }
}
