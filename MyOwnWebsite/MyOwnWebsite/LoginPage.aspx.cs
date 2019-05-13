using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PAL_properties_;
using System.Data;
using BAL_DataAcessLayer_;
using System.Threading;

namespace MyOwnWebsite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        PAL properties = new PAL();
        BAL BAl_Intercoonection = new BAL();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            properties.StaffNumber = txtname.Text.Trim();
            Session["txtname"] = txtname.Text.Trim();
            properties.Password = txtpwd.Text.Trim();
            ds = BAl_Intercoonection.Login_InterConnection(properties);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["Name"] = ds.Tables[0].Rows[0]["Name"].ToString();
                    Response.Redirect("~/Forms/Home.aspx", true);
                   
                }
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Invalid UserName / Password!. Plase Check.')",true);
                    return;
                }
            }
        }
    }
}
    