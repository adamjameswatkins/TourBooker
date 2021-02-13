using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{
	public class AppData
	{
		public List<Country> AllCountries { get; private set; }
        public SortedList<string,Country> AllCountriesByKey { get; set; }
        public void Initialize(string csvFilePath)
		{
			CsvReader reader = new CsvReader(csvFilePath);
			this.AllCountries = reader.ReadAllCountries().OrderBy(x=>x.Name).ToList();
			var dictionary = reader.ReadAllCountries().ToDictionary(x => x.Code, StringComparer.OrdinalIgnoreCase);
			this.AllCountriesByKey = new SortedList<string, Country>(dictionary);
		}
	}
}
