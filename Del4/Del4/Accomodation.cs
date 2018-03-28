using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del4
{
    class Accomodation
    {
        private int roomID;
        private int hostID;
        private string roomType;
        private string borough;
        private string neighbourhood;
        private int reviews;
        private double overallSatisfaction;
        private int accomodates;
        private int bedrooms;
        private int price;
        private int minStay;
        private double latitude;
        private double longitude;
        private string lastModified;

        public Accomodation
            (int roomID, int hostID, string roomType, string borough, string neighbourhood,
            int reviews, double overallSatisfaction, int accomodates, int bedrooms, int price,
            int minStay, double latitude, double longitude, string lastModified)
                {
                this.roomID = roomID; 
                this.hostID = hostID;
                this.roomType = roomType;
                this.borough = borough;
                this.neighbourhood = neighbourhood;
                this.reviews = reviews;
                this.overallSatisfaction = overallSatisfaction;
                this.accomodates = accomodates;
                this.bedrooms = bedrooms;
                this.price = price;
                this.minStay = minStay;
                this.latitude = latitude;
                this.longitude = longitude;
                this.lastModified = lastModified;
                }

        public int RoomID { get => roomID; set => roomID = value; }
        public int HostID { get => hostID; set => hostID = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string Borough { get => borough; set => borough = value; }
        public string Neighbourhood { get => neighbourhood; set => neighbourhood = value; }
        public int Reviews { get => reviews; set => reviews = value; }
        public double OverallSatisfaction { get => overallSatisfaction; set => overallSatisfaction = value; }
        public int Accomodates { get => accomodates; set => accomodates = value; }
        public int Bedrooms { get => bedrooms; set => bedrooms = value; }
        public int Price { get => price; set => price = value; }
        public int MinStay { get => minStay; set => minStay = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string LastModified { get => lastModified; set => lastModified = value; }
    }
}

