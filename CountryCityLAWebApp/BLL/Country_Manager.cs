using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityLAWebApp.DAL;
using CountryCityLAWebApp.MODEL;

namespace CountryCityLAWebApp.BLL
{
    public class Country_Manager
    {
        countrygatewayDB aCountrygatewayDb = new countrygatewayDB();

        public String Save(Country aCountry)
        {
            if (!aCountrygatewayDb.IfCountryNameExist(aCountry.CountryName))
            {
                if (aCountrygatewayDb.Save(aCountry) > 0)
                {
                    return "Save SuccessFull";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "Country Name Already Exist";
            }
        }

        public List<Country> GetAllCountrys()
        {
            return aCountrygatewayDb.GetAllCountrys();
        }

        public int GetCountryNameReplaceId(string nameOfCountry)
        {
            return aCountrygatewayDb.GetCountryNameReplaceId(nameOfCountry);
        }
    }
}