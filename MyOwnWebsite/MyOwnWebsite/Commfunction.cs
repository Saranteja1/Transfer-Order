using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

namespace MyOwnWebsite
{
    public class Commfunction
    {

        public void Dropdown(DropDownList ddl, DataSet ds, string valueField, string TextField)
        {
            ddl.DataSource = null;
            ddl.Items.Clear();
            ddl.DataSource = ds.Tables[0];
            ddl.DataValueField = TextField;
            ddl.DataTextField = valueField;
            ddl.DataBind();
            ListItem LI = new ListItem("::Select::", "0");
            ddl.Items.Insert(0, LI);
        }
        public void DropdownForViewPage(DropDownList ddl, DataSet ds_binding, string valueField, string TextField)
        {
            ddl.DataSource = null;
            ddl.Items.Clear();
            ddl.DataSource = ds_binding.Tables[0];
            ddl.DataValueField = TextField;
            ddl.DataTextField = valueField;
            ddl.DataBind();
            ListItem LI = new ListItem("::Select::", "0");
            ddl.Items.Insert(0, LI);
        }
    }
}