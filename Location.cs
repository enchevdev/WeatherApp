using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    internal class Location
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        



        public Location(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}
