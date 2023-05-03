using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCVCountries
{
    public class CountryView
    {
        public Country displayCountry;
        public CountryView(Country displayCountry)
        {
            this.displayCountry = displayCountry;
        }

        public void Display()
        {
            Console.WriteLine("Country: " + displayCountry.Name);
            Console.WriteLine("Continent: "+ displayCountry.Continent);
            Console.WriteLine("Colors: ");
            foreach(string color in displayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }

    }
}
