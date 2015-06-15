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
    public partial class CountryUI : System.Web.UI.Page
    {
        Country_Manager aManager = new Country_Manager();
        Country aCountry = new Country();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            aManager.GetAllCountrys();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            aCountry.CountryName = countryNameTextBox.Text;
            aCountry.AboutCountry = aboutCountryTextBox.Text;
            msgLabel.Text=aManager.Save(aCountry);
            countryinfoListGridView.DataBind();
            aManager.GetAllCountrys();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = String.Empty;
            aboutCountryTextBox.Text = String.Empty;
        }

        protected void countryinfoListGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}