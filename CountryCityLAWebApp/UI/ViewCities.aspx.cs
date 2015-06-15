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
    public partial class ViewCities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowDropdown();
            }
            viewCitiesGridView.DataSource = aCityManager.GetviewCities();
            viewCitiesGridView.DataBind();
        }
        Country_Manager aManager = new Country_Manager();
        City_Manager aCityManager = new City_Manager();
        City aCity = new City();
        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchCityName = searchCityTextBox.Text;
            //aCity.CityName = searchCityTextBox.Text;
            if (searchByCityNameRadioButton.Checked)
            {
                viewCitiesGridView.DataSource = aCityManager.SearchByViewCityinfo(searchCityName);
                viewCitiesGridView.DataBind();
               // aCityManager.SearchByViewCityinfo(aCity.CityName);
            }
            else if (searchByCountryNameRadioButton.Checked)
            {
                string searchCountryName = countryDropDownList.SelectedItem.ToString();
               // aCity.CountryNameinCity = countryDropDownList.SelectedItem.ToString();
                viewCitiesGridView.DataSource = aCityManager.SearchByViewCountryinfo(searchCountryName);

                viewCitiesGridView.DataBind();
            }
            else
            {
                msgLabel.Text = "Please Select An option From Radio Button";
            }
            searchCityTextBox.Text = String.Empty;
        }
        public void ShowDropdown()
        {
            countryDropDownList.DataSource = aManager.GetAllCountrys();
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
        }

        protected void viewCitiesGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void viewCitiesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            viewCitiesGridView.PageIndex = e.NewPageIndex;
            viewCitiesGridView.DataBind();
        }

        protected void searchByCityNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchByCityNameRadioButton.Checked = !searchByCountryNameRadioButton.Checked;
        }

        protected void searchByCountryNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchByCountryNameRadioButton.Checked = !searchByCityNameRadioButton.Checked;
        }

    }
}