using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MyOwnWebsite.MaterPage
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblName.Text = "Welcome To" + " [" + Session["txtname"] + "-" + Session["Name"] + "] ";
            }
        }
    }
}
 