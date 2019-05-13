using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BAL_DataAcessLayer_;
using PAL_properties_;

using MyOwnWebsite;

namespace MyOwnWebsite.Forms
{
    public partial class Departmnet : System.Web.UI.Page
    {

        BAL business = new BAL();
        PAL properties = new PAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Commfunction ddl_function = new Commfunction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDetails();
            }
        }
        public void BindDetails()
        {
            ds = business.DropDownViewScreenBAL(properties);
            ddlempno.DataSource = ds.Tables[0];
            ddlempno.DataTextField = "staffnumber";
            ddlempno.DataValueField = "Name";
            ddlempno.DataBind();
            ListItem li = new ListItem("::Select::", "0");
            ddlempno.Items.Insert(0, li);
        }

        protected void ddlempno_SelectedIndexChanged(object sender, EventArgs e)
        {

            string SpllitingCharacters = ddlempno.SelectedItem.Text.Trim();
            string[] Splitting = SpllitingCharacters.Trim().Split('-');
            properties.StaffNumber = Splitting[0];
            string StaffNumber = properties.StaffNumber;
            Session["Staffnumber"] = StaffNumber;
            ds = business.DropDownViewDropDownScreenBAL(properties);
            foreach (DataTable dt in ds.Tables)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtstaffno.Text = dt.Rows[i]["staffnumber"].ToString();
                    txtname.Text = dt.Rows[i]["Name"].ToString();
                    txtdept.Text = dt.Rows[i]["Department"].ToString();
                    txtdesgination.Text = dt.Rows[i]["Desgination"].ToString();
                    txtloaction.Text = dt.Rows[i]["Location"].ToString();
                    txtluster.Text = dt.Rows[i]["Cluster"].ToString();
                    txtemail.Text = dt.Rows[i]["Email"].ToString();
                    txtadress.Text = dt.Rows[i]["Adress"].ToString();
                    txtimmedaitesup.Text = dt.Rows[i]["ImmedaiteSup"].ToString();
                    txtuplinesup.Text = dt.Rows[i]["UplineSup"].ToString();
                    ReadOnly();
                    drpselectionprjct.SelectedValue = dt.Rows[i]["SelectProcess"].ToString();
                    drpselectionprjct.Attributes.Add("disabled", "disabled");
                    if (drpselectionprjct.SelectedItem.Value.Equals("1"))
                    {
                        divprjct.Style.Add("display", "block");
                        drpexistingprjct.Style.Add("display", "block");
                        divnewprjct.Style.Add("display", "block");
                        drpnewprjct.Style.Add("display", "block");

                        divdept.Style.Add("display", "none");
                        drpexisitngdept.Style.Add("display", "none");
                        divnewdept.Style.Add("display", "none");
                        drpnewdept.Style.Add("display", "none");

                        divfunction.Style.Add("display", "none");
                        drpexistingfunction.Style.Add("display", "none");
                        divexisfunction.Style.Add("display", "none");
                        drpnewfunction.Style.Add("display", "none");
                        Binddropdownproject(properties);
                        drpexistingprjct.SelectedValue= dt.Rows[i]["ExistingProject"].ToString();
                        drpnewprjct.SelectedValue= dt.Rows[i]["NewProject"].ToString();
                        drpexistingprjct.Attributes.Add("disabled", "disabled");
                        drpnewprjct.Attributes.Add("disabled", "disabled");


                    }
                    if (drpselectionprjct.SelectedItem.Value.Equals("2"))
                    {
                        divprjct.Style.Add("display", "none");
                        drpexistingprjct.Style.Add("display", "none");
                        divnewprjct.Style.Add("display", "none");
                        drpnewprjct.Style.Add("display", "none");

                        divdept.Style.Add("display", "block");
                        drpexisitngdept.Style.Add("display", "block");
                        divnewdept.Style.Add("display", "block");
                        drpnewdept.Style.Add("display", "block");

                        divfunction.Style.Add("display", "none");
                        drpexistingfunction.Style.Add("display", "none");
                        divexisfunction.Style.Add("display", "none");
                        drpnewfunction.Style.Add("display", "none");
                        BinddropdownDepartment(properties);
                        drpexisitngdept.SelectedValue=dt.Rows[i]["ExistingDept"].ToString();
                        drpnewdept.SelectedValue= dt.Rows[i]["NewDept"].ToString();
                        drpexisitngdept.Attributes.Add("disabled", "disabled");
                        drpnewdept.Attributes.Add("disabled", "disabled");

                    }
                    if (drpselectionprjct.SelectedItem.Value.Equals("3"))
                    {
                        divprjct.Style.Add("display", "none");
                        drpexistingprjct.Style.Add("display", "none");
                        divnewprjct.Style.Add("display", "none");
                        drpnewprjct.Style.Add("display", "none");

                        divdept.Style.Add("display", "none");
                        drpexisitngdept.Style.Add("display", "none");
                        divnewdept.Style.Add("display", "none");
                        drpnewdept.Style.Add("display", "none");

                        divfunction.Style.Add("display", "block");
                        drpexistingfunction.Style.Add("display", "block");
                        divexisfunction.Style.Add("display", "block");
                        drpnewfunction.Style.Add("display", "block");
                        BinddropdownFunction(properties);
                        drpexistingfunction.SelectedValue = dt.Rows[i]["ExistingFunction"].ToString();
                        drpnewfunction.SelectedValue = dt.Rows[i]["NewFunction"].ToString();
                        drpexistingfunction.Attributes.Add("disabled", "disabled");
                        drpnewfunction.Attributes.Add("disabled", "disabled");
                    }
                }
            }
        }
        public void Binddropdownproject(PAL properties)
        {

            ds = business.DropDownProjectBAL(properties);
            ddl_function.Dropdown(drpexistingprjct, ds, "ProjectName", "ProjectId");
            ddl_function.Dropdown(drpnewprjct, ds, "ProjectName", "ProjectId");
        }
        public void BinddropdownDepartment(PAL properties)
        {

            ds = business.DropDownDepartmentBAL(properties);
            ddl_function.Dropdown(drpexisitngdept, ds, "DeptName", "DeptID");
            ddl_function.Dropdown(drpnewdept, ds, "DeptName", "DeptID");
        }
        public void BinddropdownFunction(PAL properties)
        {

            ds = business.DropDownFunctionBAL(properties);
            ddl_function.Dropdown(drpexistingfunction, ds, "FUNCTIONName", "FUNCTIONId");
            ddl_function.Dropdown(drpnewfunction, ds, "FUNCTIONName", "FUNCTIONId");
        }


        protected void  ReadOnly()
        {
            txtstaffno.ReadOnly = true;
            txtstaffno.ReadOnly = true;
            txtname.ReadOnly = true;
            txtdept.ReadOnly = true;
            txtdesgination.ReadOnly = true;
            txtloaction.ReadOnly = true;
            txtluster.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtadress.ReadOnly = true;
            txtimmedaitesup.ReadOnly = true;
            txtuplinesup.ReadOnly = true;
         

        }
    }
}


                
               

                   
            
 