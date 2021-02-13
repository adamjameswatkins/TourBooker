using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{
    public class AppData
    {
        public List<Country> AllCountries { get; private set; }
        public Dictionary<CountryCode, Country> AllCountriesByKey { get; set; }
        public void Initialize(string csvFilePath)
        {
            CsvReader reader = new CsvReader(csvFilePath);
            this.AllCountries = reader.ReadAllCountries().OrderBy(x => x.Name).ToList();
            this.AllCountriesByKey = reader.ReadAllCountries().ToDictionary(x => x.Code);
        }
    }
}
