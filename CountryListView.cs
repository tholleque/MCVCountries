using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCVCountries
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; } = new List<Country>();
        public CountryListView(List<Country> countries) 
        {
            this.Countries = countries;
        }
        
        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++) 
            {
                Console.WriteLine(i + " " + Countries[i].Name);
            }
        }
    }
}
