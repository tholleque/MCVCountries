using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCVCountries
{
    public enum Continent
    {
        Africa,
        Asia,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica 
    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string name, Continent continent, List<string> colors) 
        {
            Name = name;
            Continent = continent;
            Colors = colors;

        }
    }
}
