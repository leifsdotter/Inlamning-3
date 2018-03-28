using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Del4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LAPTOP-OKRU7LGI;Initial Catalog=Airbnb;Integrated Security=True";

    //Listan med Accomodations populeras per stad, i=0 -->Amsterdam, i=1 -->Barcelona, i=2 -->Boston
    City[] stader = new City[]
                {
                new City("Amsterdam", 0, 0, 0, 0, 0),
                new City("Barcelona", 0, 0, 0, 0, 0),
                new City("Boston", 0, 0, 0, 0, 0)
                };
            for (int i = 0; i < stader.Length; i++)
                {
                connection.Open();
                SqlCommand myQuery = new SqlCommand("Select *From " + stader[i].CityName, connection); //SqlCommand(SQL-query, uppkoppling till SQL-databasen)
                SqlDataReader sql = myQuery.ExecuteReader();

            while (sql.Read())
                {
                    int roomID = (int)sql["room_id"];
                    int hostID = (int)sql["host_id"];
                    string roomType = sql["room_type"].ToString();
                    string borough = sql["borough"].ToString();
                    string neighbourhood = sql["neighborhood"].ToString();
                    int reviews = (int)sql["reviews"];
                    double overallSatisfaction = (double)sql["overall_satisfaction"];
                    int accomodates = (int)sql["accommodates"];
                    double a = (double)sql["bedrooms"];
                    int bedrooms = (int)Math.Round(a);
                    double b = (double)sql["price"];
                    int price = (int)Math.Round(b);
                    string var12 = sql["minstay"].ToString();
                    int minstay;
                    int.TryParse(var12, out minstay);
                    double c = (double)sql["latitude"];
                    int latitude = (int)Math.Round(c);
                    double d = (double)sql["longitude"];
                    int longitude = (int)Math.Round(d);
                    string lastModified = sql["last_modified"].ToString();
                    System.Console.WriteLine(lastModified);
                    //En lista med Accomodation skapas och fylls på
                    Accomodation singleAccommodation = new Accomodation(roomID, hostID, roomType, borough, neighbourhood, reviews, overallSatisfaction, accomodates, bedrooms, price, minstay, latitude, longitude, lastModified);
                    stader[i].addAccomodation(singleAccommodation);
            }
                connection.Close();
            }

                chart7.Titles.Add("Amsterdam price");
                chart7.ChartAreas[0].AxisX.Title = "Room";
                chart7.ChartAreas[0].AxisY.Title = "Price";

                chart2.Titles.Add("Barcelona price");
                chart2.ChartAreas[0].AxisX.Title = "Room";
                chart2.ChartAreas[0].AxisY.Title = "Price";

                chart3.Titles.Add("Boston price");
                chart3.ChartAreas[0].AxisX.Title = "Room";
                chart3.ChartAreas[0].AxisY.Title = "Price";

                chart4.Titles.Add("Amsterdam price/overall satisfaction");
                chart4.ChartAreas[0].AxisX.Title = "Price";
                chart4.ChartAreas[0].AxisY.Title = "Overall Satisfation";

                chart5.Titles.Add("Barcelona price/overall satisfaction");
                chart5.ChartAreas[0].AxisX.Title = "Price";
                chart5.ChartAreas[0].AxisY.Title = "Overall Satisfation";

                chart6.Titles.Add("Boston price/overall satisfaction");
                chart6.ChartAreas[0].AxisX.Title = "Price";
                chart6.ChartAreas[0].AxisY.Title = "Overall Satisfation";


                //Histogram 1,2 och 3
                foreach (Accomodation a in stader[0].Accomodations.Where(x => x.RoomType == "Private room"))
                {
                    chart7.Series["Series1"].Points.AddY(a.Price);
                }


                chart7.Series["Series1"].ChartType = SeriesChartType.Column;


                foreach (Accomodation a in stader[1].Accomodations.Where(x => x.RoomType == "Private room"))
                {
                    chart2.Series["Series1"].Points.AddY(a.Price);
                }

                chart2.Series["Series1"].ChartType = SeriesChartType.Column;

                foreach (Accomodation a in stader[2].Accomodations.Where(x => x.RoomType == "Private room"))
                {
                    chart3.Series["Series1"].Points.AddY(a.Price);
                }

                chart3.Series["Series1"].ChartType = SeriesChartType.Column;

                //Scatterplott 1,2 och 3 
                foreach (Accomodation a in stader[0].Accomodations.Where(x => x.OverallSatisfaction != 0 && x.OverallSatisfaction < 4.5))
                {
                    chart4.Series["Series1"].Points.AddXY(a.Price, a.OverallSatisfaction);
                }

                chart4.Series["Series1"].ChartType = SeriesChartType.Point;

                foreach (Accomodation a in stader[1].Accomodations.Where(x => x.OverallSatisfaction != 0 && x.OverallSatisfaction < 4.5))
                {
                    chart5.Series["Series1"].Points.AddXY(a.Price, a.OverallSatisfaction);
                }

                chart5.Series["Series1"].ChartType = SeriesChartType.Point;

                foreach (Accomodation a in stader[2].Accomodations.Where(x => x.OverallSatisfaction != 0 && x.OverallSatisfaction < 4.5))
                {
                    chart6.Series["Series1"].Points.AddXY(a.Price, a.OverallSatisfaction);
                }

                chart6.Series["Series1"].ChartType = SeriesChartType.Point;


    } 


    }

}
        










