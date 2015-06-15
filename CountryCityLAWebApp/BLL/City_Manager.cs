using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityLAWebApp.DAL;
using CountryCityLAWebApp.MODEL;

namespace CountryCityLAWebApp.BLL
{
    public class City_Manager
    {
        CitygatewayDB aCitygatewayDb = new CitygatewayDB();

        public String Save(City aCity)
        {
            if (!aCitygatewayDb.IfCityyNameExist(aCity.CityName))
            {
                if (aCitygatewayDb.Save(aCity) > 0)
                {
                    return "SAve Successfull";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return " City Name Already Exist";
            }
        }

        public List<City> GetAllCitys()
        {
            return aCitygatewayDb.GetAllCitys();
        }

        public List<City> GetviewCities()
        {
            return aCitygatewayDb.GetviewCities();
        }

        public List<City> SearchByViewCityinfo(String searchCity)
        {
            return aCitygatewayDb.SearchByViewCityinfo(searchCity);
        }

        public List<City> SearchByViewCountryinfo(String searchCountry)
        {
            return aCitygatewayDb.SearchByViewCountryinfo(searchCountry);
        }
    }
}