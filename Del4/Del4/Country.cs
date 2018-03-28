using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del4
{
    class Country
        {
        private string countryName;
        private int countryInhabitants;
        private int bnpPerCapita;
        private List<City> cities;

        public string CountryName { get => countryName; set => countryName = value; }
        public int CountryInhabitants { get => countryInhabitants; set => countryInhabitants = value; }
        public int BnpPerCapita { get => bnpPerCapita; set => bnpPerCapita = value; }
        public List<City> Cities { get => cities; set => cities = value; }

        public Country(string countryName, int countryInhabitants, int bnbPerCapita)
            {
            this.countryName = countryName;
            this.countryInhabitants = countryInhabitants;
            this.bnpPerCapita = bnbPerCapita;
            }
        }
}
