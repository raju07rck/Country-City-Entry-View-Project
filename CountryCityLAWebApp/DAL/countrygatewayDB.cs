using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityLAWebApp.MODEL;

namespace CountryCityLAWebApp.DAL
{
    public class countrygatewayDB
    {
        public string connectionString =ConfigurationManager.ConnectionStrings["CountryCityConnection"].ConnectionString;

        public int Save(Country aCountry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_Country VALUES('"+aCountry.CountryName+"','"+aCountry.AboutCountry+"');";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffacted=command.ExecuteNonQuery();
            connection.Close();
            return rowEffacted;
        }

        public bool IfCountryNameExist(String nameOfCountry)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Country WHERE country_Name= '" + nameOfCountry + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool IfCountryNameExist = false;
            while (reader.Read())
            {
                IfCountryNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return IfCountryNameExist;
        }
        public List<Country> GetAllCountrys()
        {
            List<Country> countryList = new List<Country>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Country ORDER BY country_Name ASC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Serial = serial;
                aCountry.Id = int.Parse(reader["id"].ToString());
                aCountry.CountryName = reader["country_Name"].ToString();
                aCountry.AboutCountry = reader["about_Country"].ToString();
                countryList.Add(aCountry);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        public Country GetCountryById(int idNo)
        {
            List<Country> countryList = new List<Country>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_Country WHERE id= '" + idNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Id = int.Parse(reader["id"].ToString());
                aCountry.CountryName = reader["country_Name"].ToString();
                aCountry.AboutCountry = reader["about_Country"].ToString();
                countryList.Add(aCountry);

            }
            reader.Close();
            connection.Close();
            return countryList.FirstOrDefault();
        }


        public int GetCountryNameReplaceId(string nameOfCountry)
        {
            int countryid = 0;
            string query = "SELECT id from tbl_Country WHERE country_Name = '" + nameOfCountry + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                countryid = Convert.ToInt32(reader["id"].ToString());
            }
            reader.Close();
            connection.Close();
            return countryid;
        }

    }
}