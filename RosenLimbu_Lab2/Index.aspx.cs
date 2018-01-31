using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*Author: Rosen Limbu
 * Date: January 12, 2018
 * Descrption: This is the first page where I pick on the date send the date to the 2nd page.
 * */
namespace RosenLimbu_Lab2
{
    public partial class Index : System.Web.UI.Page
    {
        int first = 0;
        int second = 0;
        int third = 0;

        //on load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["first"] != null)
            {
                first = (int)Application["first"];
            }

            if(Application["second"] != null)
            {
                second = (int)Application["second"];
            }
            if (Application["third"] != null)
            {
                third = (int)Application["third"];
            }

            if ((Calendar1.SelectedDate == null) || (!IsPostBack))
                lblSelectedDate.Text = "Please select an appropriate date!";

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text = "You have selected " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //copy and pasted from dayrender because method was protected
            DateTime firstSat; //means the next Saturday
            DateTime secondSat; //second Saturday
            DateTime thirdSat; //third Saturday

            if ((int)DateTime.Today.DayOfWeek == 7) //assume saturday
            {
                firstSat = DateTime.Today.AddDays(6); //monday to saturday is 6 days
            }
            else
            {
                firstSat = DateTime.Today.AddDays(6 - (int)DateTime.Today.DayOfWeek);
            }

            secondSat = firstSat.AddDays(7); //next saturday
            thirdSat = secondSat.AddDays(7); //third saturday

            //when the selected date is selected. send the response to the result page with respect to the application
            if(Calendar1.SelectedDate == firstSat)
            { 
            first++;
            Application.Lock();
            Application["first"] = first;
            Application.UnLock();
            }
            if (Calendar1.SelectedDate == secondSat)
            {
            second++;
            Application.Lock();
            Application["second"] = second;
            Application.UnLock();
            }
            if (Calendar1.SelectedDate == thirdSat)
            {
            third++;
            Application.Lock();
            Application["third"] = third;
            Application.UnLock();
            }
            Response.Redirect("~/Result.aspx");
        }

        //protected doesnt allow you to pass any value
        //DayRender is a an event handler for the calendar control in which I can modify what dates can be viewed
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime first; //means the next Saturday
            if ((int)DateTime.Today.DayOfWeek == 7) //assume saturday
            {
                first = DateTime.Today.AddDays(6); //monday to saturday is 6 days
            }
            else
            {
                first = DateTime.Today.AddDays(6 - (int)DateTime.Today.DayOfWeek);
            }

            DateTime second = first.AddDays(7); //next saturday
            DateTime third = second.AddDays(7); //third saturday


            if (e.Day.Date != first && e.Day.Date != second && e.Day.Date != third) //e.day.date is selecting a date
            {
                e.Day.IsSelectable = false; //block out all the days in the month
                e.Cell.BackColor = System.Drawing.Color.Gray; //make the cell color to be grey 
            }
        }
    }
}