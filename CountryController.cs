using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCVCountries
{
    public class CountryController
    {
        public List<Country> CountryDB { get; set;} = new List<Country>();

        public CountryController() 
        {
            CountryDB.Add(new Country("United States", Continent.NorthAmerica, new List<string>() { "Red", "White", "Blue"}));
            CountryDB.Add(new Country("Canada", Continent.NorthAmerica, new List<string>() { "Red", "White" }));
            CountryDB.Add(new Country("Brazil", Continent.SouthAmerica, new List<string>() { "Green", "Yellow" }));
            CountryDB.Add(new Country("China", Continent.Asia, new List<string>() { "Red", "Yellow" }));
        }
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);

            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            clv.Display();
            int pick = int.Parse(Console.ReadLine());
            Country c = CountryDB[pick];
            CountryAction(c);
        }
    }
}
