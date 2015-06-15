using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityLAWebApp.MODEL;

namespace CountryCityLAWebApp.DAL
{
    public class CitygatewayDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["CountryCityConnection"].ConnectionString;

        public int Save(City aCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_City VALUES('" + aCity.CityName + "','" + aCity.AboutCity + "','"+aCity.CityDwellers+"', '"+aCity.CityLocation+"','"+aCity.CityWeather+"','"+aCity.CountryID+"');";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffacted = command.ExecuteNonQuery();
            connection.Close();
            return rowEffacted;
        }

        public bool IfCityyNameExist(String nameOfCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_City WHERE city_Name= '" + nameOfCity + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool IfCityyNameExist = false;
            while (reader.Read())
            {
                IfCityyNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return IfCityyNameExist;
        }

        public List<City> GetAllCitys()
        {
            List<City> cityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            //string query = "SELECT * FROM tbl_City";
            string query = @"select city_Id,city_Name,about_City,city_Dwellers, city_Location, city_Weather,country_Name 
                            from tbl_City LEFT JOIN tbl_Country ON country_Id=id ORDER BY city_Name ASC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CitySerial = serial;
                aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                //aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                aCity.CountryNameinCity= reader["country_Name"].ToString();
                cityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cityList;
        }

        public City GetCityById(int cityIdNo)
        {
            List<City> cityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_City";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                cityList.Add(aCity);

            }
            reader.Close();
            connection.Close();
            return cityList.FirstOrDefault();
        }

        public List<City> GetviewCities()
        {
            List<City> viewCityList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"select city_Name,about_City,city_Dwellers, city_Location, city_Weather,country_Name, about_Country 
                            from tbl_City LEFT JOIN tbl_Country ON country_Id=id ORDER BY city_Name ASC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CitySerial = serial;
                //aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                //aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                aCity.CountryNameinCity = reader["country_Name"].ToString();
                aCity.AboutCountryinCity = reader["about_Country"].ToString();
                viewCityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return viewCityList;
        }
        public List<City> SearchByViewCityinfo(String searchCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
          //String query = "SELECT * FROM tb_cityInfo WHERE cityName like '%" + searchCity + "%' ";
            String query = @"Select tbl_City.city_Name, tbl_City.about_City, tbl_City.city_Dwellers, tbl_City.city_Location, tbl_City.city_Weather, tbl_Country.country_Name, tbl_Country.about_Country From tbl_City INNER JOIN tbl_Country ON tbl_City.country_Id=tbl_Country.id WHERE tbl_City.city_Name like '%"+searchCity+"%' ORDER BY tbl_City.city_Name";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> searchViewcityList = new List<City>();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CitySerial = serial;
                //aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                //aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                aCity.CountryNameinCity = reader["country_Name"].ToString();
                aCity.AboutCountryinCity = reader["about_Country"].ToString();
                searchViewcityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return searchViewcityList;
        }

        public List<City> SearchByViewCountryinfo(String searchCountry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //String query = "SELECT * FROM tb_cityInfo WHERE cityName like '%" + searchCity + "%' ";
            String query = @"Select tbl_City.city_Name, tbl_City.about_City, tbl_City.city_Dwellers, tbl_City.city_Location, tbl_City.city_Weather, tbl_Country.country_Name, tbl_Country.about_Country From tbl_City INNER JOIN tbl_Country ON tbl_City.country_Id=tbl_Country.id WHERE tbl_Country.country_Name like '%" + searchCountry + "%' ORDER BY tbl_City.city_Name";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> searchViewcountryList = new List<City>();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CitySerial = serial;
                //aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                //aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                aCity.CountryNameinCity = reader["country_Name"].ToString();
                aCity.AboutCountryinCity = reader["about_Country"].ToString();
                searchViewcountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return searchViewcountryList;
        }

    public List<City> GetviewCountry()
        {
            List<City> viewCountryList = new List<City>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"select city_Name,about_City,city_Dwellers, city_Location, city_Weather,country_Name, about_Country from tbl_City LEFT JOIN tbl_Country ON country_Id=id ORDER BY city_Name ASC";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CitySerial = serial;
               // aCity.CityId = int.Parse(reader["city_Id"].ToString());
                aCity.CountryNameinCity = reader["country_Name"].ToString();
                aCity.AboutCountryinCity = reader["about_Country"].ToString();
                aCity.CityName = reader["city_Name"].ToString();
                aCity.AboutCity = reader["about_City"].ToString();
                aCity.CityDwellers = Convert.ToInt32(reader["city_Dwellers"]);
                aCity.CityLocation = reader["city_Location"].ToString();
                aCity.CityWeather = reader["city_Weather"].ToString();
                //aCity.CountryID = Convert.ToInt32(reader["country_Id"]);
                viewCountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return viewCountryList;
        }
    }
}