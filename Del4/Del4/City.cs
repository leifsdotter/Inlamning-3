using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del4
{
    class City
        {
        private string cityName;
        private int cityInhabitants;
        private int averageIncome;
        private int numberOfTourists;
        private List<Accomodation> accomodations;
        private int numberOfAccomodations; 
        private double averageRatePerNightCity;

        public string CityName { get => cityName; set => cityName = value; }
        public int CityInhabitants { get => cityInhabitants; set => cityInhabitants = value; }
        public int AverageIncome { get => averageIncome; set => averageIncome = value; }
        public int NumberOfTourists { get => numberOfTourists; set => numberOfTourists = value; }
        public List<Accomodation> Accomodations { get => accomodations; set => accomodations = value; }

        public City
            (string cityName, int cityInhabitants, int averageIncome, int numberOfTourists,
            int numberOfAccommodations, double averageRatePerNightCity)
                {
                    this.cityName = cityName;
                    this.cityInhabitants = cityInhabitants;
                    this.averageIncome = averageIncome;
                    this.numberOfTourists = numberOfTourists;
                    this.numberOfAccomodations = numberOfAccommodations;
                    this.averageRatePerNightCity = averageRatePerNightCity;
                    createAccomodationList();
                }
        private void createAccomodationList()
            {
            accomodations = new List<Accomodation>();
            }

        public void addAccomodation(Accomodation accomodation)
            {
            accomodations.Add(accomodation);
            }
        }
}

