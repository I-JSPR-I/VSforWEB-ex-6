using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VSforWEB_ex_6
{
    public partial class Verjaardag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Datum.Text = $"Uw verjaardag is binnen {Convert.ToString(Calendar1.SelectedDate.AddDays(1).Subtract(DateTime.Now).Days)} dagen";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}