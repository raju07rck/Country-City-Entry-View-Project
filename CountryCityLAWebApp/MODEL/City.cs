using System;

namespace CountryCityLAWebApp.MODEL
{
    public class City
    {
        public int CityId { get; set; }
        public int CitySerial { get; set; }
        public string CityName { get; set; }
        public string AboutCity { get; set; }
        public int CityDwellers { get; set; }
        public string CityLocation { get; set; }
        public string CityWeather { get; set; }
        public int CountryID { get; set; }
        public string CountryNameinCity { get; set;}
        public string AboutCountryinCity { get; set; }
    }
}