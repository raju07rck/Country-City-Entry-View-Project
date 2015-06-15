using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityLAWebApp.BLL;
using CountryCityLAWebApp.MODEL;

namespace CountryCityLAWebApp.UI
{
   
    public partial class CityUI : System.Web.UI.Page
    {
        Country_Manager aManager = new Country_Manager();
        City_Manager aCityManager = new City_Manager();
        City aCity = new City();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ShowDropdown();
            }
            aCityManager.GetAllCitys();

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            aCity.CityName = cityNameTextBox.Text;
            aCity.AboutCity = aboutCityTextBox.Text;
            aCity.CityDwellers = Convert.ToInt32(cityDwellersNoTextBox.Text);
            aCity.CityLocation = cityLocationTextBox.Text;
            aCity.CityWeather = cityWeatherTextBox.Text;
            //String countryName = countryDropDownList.SelectedValue;
            aCity.CountryID = Convert.ToInt32(countryDropDownList.SelectedValue);
            //aCity.CountryID = aManager.GetCountryNameReplaceId(countryName);
            cmsgLabel.Text = aCityManager.Save(aCity);
            cityInfoListGridView.DataBind();
            aCityManager.GetAllCitys();
        }

        public void ShowDropdown()
        {
            countryDropDownList.DataSource = aManager.GetAllCountrys();
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            cityNameTextBox.Text = String.Empty;
            aboutCityTextBox.Text = String.Empty;
            cityDwellersNoTextBox.Text= String.Empty;
            cityLocationTextBox.Text = String.Empty;
            cityWeatherTextBox.Text = String.Empty;

        }
    }
}