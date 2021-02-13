using System;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{
    public class CountryCode
    {
        public string Value { get; set; }

        public CountryCode(string value)
        {
            this.Value = value;
        }

        public override string ToString() => Value;

        public override bool Equals(object obj)
        {
            if(obj is CountryCode other)
            {
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, other.Value);
            }
            return false;
        }

        public static bool operator ==(CountryCode lhs, CountryCode rhs)
        {
            if (lhs != null)
            {
                return lhs.Equals(rhs);
            }
            else
            {
                return rhs == null;
            }
        }

        public static bool operator !=(CountryCode lhs, CountryCode rhs)
        {
            return !(lhs == rhs);
        }
    }
}
