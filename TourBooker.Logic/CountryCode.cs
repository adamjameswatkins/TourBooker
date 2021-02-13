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
    }
}
