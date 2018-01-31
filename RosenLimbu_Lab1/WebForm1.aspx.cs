using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RosenLimbu_Lab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlFrom.SelectedValue = "Celsius";
                ddlTo.SelectedValue = "Fahrenheit";

            ddlFrom.Items.Add("Celsius");
            ddlFrom.Items.Add("Fahrenheit");
            ddlFrom.Items.Add("Kelvin");
            ddlTo.Items.Add("Fahrenheit");
            ddlTo.Items.Add("Kelvin");
            ddlTo.Items.Add("Celsius");
            lblConverted.Text = "";
            }

            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double result = 0;
            double output = 0;
            double input = Convert.ToDouble(txtFrom.Text);
            

            if ((ddlFrom.SelectedValue == "Celsius") && (ddlTo.SelectedValue == "Celsius"))
            {
                output = input;
            }

            else if ((ddlFrom.SelectedValue == "Fahrenheit") && (ddlTo.SelectedValue == "Celsius"))
            {
                output = ((input - 32) * 5) / 9;
            }
            else if ((ddlFrom.SelectedValue == "Kelvin") && (ddlTo.SelectedValue == "Celsius"))
            {
                output = input - 273.15;
            }
            else if ((ddlFrom.SelectedValue == "Fahrenheit") && (ddlTo.SelectedValue == "Fahrenheit"))
            {
                output = input;
            }
            else if ((ddlFrom.SelectedValue == "Kelvin") && (ddlTo.SelectedValue == "Kelvin"))
            {
                output = input;
            }
            else if ((ddlFrom.SelectedValue == "Celsius") && (ddlTo.SelectedValue == "Fahrenheit"))
            {
                output = (input * 9) / 5 + 32;
            }
            else if ((ddlFrom.SelectedValue == "Kelvin") && (ddlTo.SelectedValue == "Fahrenheit"))
            {
                output = (9 * (input-273.15))/ 5 + 32;
            }
            else if ((ddlFrom.SelectedValue == "Celsius") && (ddlTo.SelectedValue == "Kelvin"))
            {
                output = input + 273.15;
            }
            else if ((ddlFrom.SelectedValue == "Fahrenheit") && (ddlTo.SelectedValue == "Kelvin"))
            {
                output = (input + 459.67) * 5 / 9;
            }

            result = Math.Round(output, 2);
            lblConverted.Text = result.ToString();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            lblConverted.Text = "";
            inputRangeValidator.ErrorMessage = "";
            inputRequiredFieldValidator.ErrorMessage = "";
            ddlFrom.SelectedIndex = 0;
            ddlTo.SelectedIndex = 0;
        }
    }
}