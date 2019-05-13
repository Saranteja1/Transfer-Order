using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_DataAcessLayer_;
using PAL_properties_;
using System.Data;
using MyOwnWebsite;

namespace MyOwnWebsite.Forms
{
    public partial class ImmedaiteSupervisor : System.Web.UI.Page
    {
        BAL business = new BAL();
        PAL properties = new PAL();
        DataSet ds = new DataSet();
        Commfunction ddl_function = new Commfunction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                properties.StaffNumber = Session["txtname"].ToString();
                Binddropdown(properties);
                Enable();





            }
        }
        protected void Enable()
        {
            divprjct.Style.Add("display", "none");
            divnewprjct.Style.Add("display", "none");
            divdept.Style.Add("display", "none");
            divnewdept.Style.Add("display", "none");
            divfunction.Style.Add("display", "none");
            divexisfunction.Style.Add("display", "none");
            drpexistingprjct.Style.Add("display", "none");
            drpnewprjct.Style.Add("display", "none");
            drpexisitngdept.Style.Add("display", "none");
            drpnewdept.Style.Add("display", "none");
            drpexistingfunction.Style.Add("display", "none");
            drpnewfunction.Style.Add("display", "none");

        }
        public void Binddropdown(PAL properties)
        {

            ds = business.DropDownBal(properties);
            ddl_function.Dropdown(ddlempno, ds, "EmployeeName", "EmployeeNumber");

        }

        protected void ddlempno_SelectedIndexChanged(object sender, EventArgs e)
        {
            properties.EmployeeNumberorName = ddlempno.SelectedItem.Text.Substring(0, 4);
            if (properties.EmployeeNumberorName != null)
            {

                ds = business.SelectDropDownBAL(properties);
                properties.ImmedaiteFormStaffNumber = ds.Tables[0].Rows[0]["Staffno"].ToString();
                txtstaffno.Text = properties.ImmedaiteFormStaffNumber;
                properties.ImmedaiteFormName = ds.Tables[0].Rows[0]["Name"].ToString();
                txtname.Text = properties.ImmedaiteFormName;
                properties.ImmedaiteFormDept = ds.Tables[0].Rows[0]["Department"].ToString();
                txtdept.Text = properties.ImmedaiteFormDept;
                properties.ImmedaiteFormDesgination = ds.Tables[0].Rows[0]["Desgination"].ToString();
                txtdesgination.Text = properties.ImmedaiteFormDesgination;
                properties.ImmedaiteFormLocation = ds.Tables[0].Rows[0]["Location"].ToString();
                txtloaction.Text = properties.ImmedaiteFormLocation;
                properties.ImmedaiteFormCluster = ds.Tables[0].Rows[0]["Cluster"].ToString();
                txtluster.Text = properties.ImmedaiteFormCluster;
                properties.ImmedaiteFormEmailadress = ds.Tables[0].Rows[0]["Email"].ToString();
                txtemail.Text = properties.ImmedaiteFormEmailadress;
                properties.ImmedaiteFormAdress = ds.Tables[0].Rows[0]["Adress"].ToString();
                txtadress.Text = properties.ImmedaiteFormAdress;
                properties.ImmedaiteFormImmedaiteSup = ds.Tables[0].Rows[0]["ImmedaiteSupervisor"].ToString();
                properties.ImmedaiteFormImmedaiteSupName = ds.Tables[0].Rows[0]["ImmedaiteSupervisorName"].ToString();
                txtimmedaitesup.Text = properties.ImmedaiteFormImmedaiteSup + "-" + properties.ImmedaiteFormImmedaiteSupName;
                properties.ImmedaiteFormUplineSup = ds.Tables[0].Rows[0]["UplineSupervisor"].ToString();
                properties.ImmedaiteFormUplineSupName = ds.Tables[0].Rows[0]["UplineSupervisorName"].ToString();
                txtuplinesup.Text = properties.ImmedaiteFormUplineSup + "-" + properties.ImmedaiteFormUplineSupName;
                Readonly();

                BindDropdownprocess();



            }
        }
        protected void Readonly()
        {
            txtstaffno.Attributes.Add("readonly", "readonly");
            txtname.Attributes.Add("readonly", "readonly");
            txtdept.Attributes.Add("readonly", "readonly");
            txtdesgination.Attributes.Add("readonly", "readonly");
            txtloaction.Attributes.Add("readonly", "readonly");
            txtluster.Attributes.Add("readonly", "readonly");
            txtemail.Attributes.Add("readonly", "readonly");
            txtadress.Attributes.Add("readonly", "readonly");
            txtimmedaitesup.Attributes.Add("readonly", "readonly");
            txtuplinesup.Attributes.Add("readonly", "readonly");
        }
        public void BindDropdownprocess()
        {
            List<ListItem> li = new List<ListItem>();
          
            li.Add(new ListItem("Project", "1"));
            li.Add(new ListItem("Department", "2"));
            li.Add(new ListItem("Function", "3"));
            drpselectionprjct.Items.AddRange(li.ToArray());

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
        protected void drpselectionprjct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (drpselectionprjct.SelectedItem.Value.Equals("0"))
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alert", "alert('msg');", true);
                    return;
                }
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

                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void btnapprove_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDetails(properties);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
        protected void InsertDetails(PAL properties)

        {
            if(drpselectionprjct.SelectedIndex==0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Select Proces For Further Process!')", true);
                return;
            }
            if(drpselectionprjct.SelectedItem.Value=="1")
            {
                if(drpexistingprjct.SelectedIndex==0  )
                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Please Select Exisitng Project!')", true);
                    return;
                 
                }
                if (drpnewprjct.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Please Select New Project!')", true);
                    return;
                   
                }
            }
            if (drpselectionprjct.SelectedItem.Value == "2")
            {
                if(drpexisitngdept.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Please Select Existing Department!')", true);
                    return;
                    
                }
                if (drpnewdept.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Please Select New Department!')", true);
                    return;
                    
                }
            }
            if (drpselectionprjct.SelectedItem.Value == "3")
            {
                if (drpexistingfunction.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('Please Select Existing Function!')", true);
                    return;
                    
                }
                if (drpnewfunction.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "clentscript", "alert('please Select New Function!')", true);
                    return;
                  
                }
            }
            try
            {
                properties.StaffNumber = txtstaffno.Text;
                properties.ImmedaiteFormName = txtname.Text;
                properties.ImmedaiteFormDept = txtdept.Text;
                properties.ImmedaiteFormDesgination = txtdesgination.Text;
                properties.ImmedaiteFormLocation = txtloaction.Text;
                properties.ImmedaiteFormCluster = txtluster.Text;
                properties.ImmedaiteFormEmailadress = txtemail.Text;
                properties.ImmedaiteFormAdress = txtadress.Text;
                properties.ImmedaiteFormImmedaiteSup = txtimmedaitesup.Text;
                properties.ImmedaiteFormUplineSup = txtuplinesup.Text;
                if (!string.IsNullOrEmpty(drpselectionprjct.SelectedItem.ToString()))
                {
                    properties.DropDownSelectionProcess = drpselectionprjct.SelectedItem.Value;
                    if (properties.DropDownSelectionProcess.Equals("1"))
                    {
                        properties.DropdownExistingProject = drpexistingprjct.SelectedItem.Value;
                        properties.DropdownNewProject = drpnewprjct.SelectedItem.Value;
                    }
                    if (properties.DropDownSelectionProcess.Equals("2"))
                    {
                        properties.DropExistingDept = drpexisitngdept.SelectedItem.Value;
                        properties.DropNewDept = drpnewdept.SelectedItem.Value;
                    }
                    if (properties.DropDownSelectionProcess.Equals("3"))
                    {
                        properties.DropExistingFunction = drpexistingfunction.SelectedItem.Value;
                        properties.DropNewFunction = drpnewfunction.SelectedItem.Value;
                    }
                }
                //StoredProcedure
                business.InsertImmediateBAL(properties);
                business.UpdateImmediateBAL(properties);
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alert", "alert('Records Inserted!');", true);
                return;

            }
            catch (Exception Ex)
            {

                throw;
            }
        }

        protected void drpexistingprjct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                properties.DropdownExistingProject = drpexistingprjct.SelectedItem.Value;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void drpnewprjct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                properties.DropNewDept = drpnewprjct.SelectedItem.Value;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void drpexisitngdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                properties.DropExistingDept = drpexisitngdept.SelectedItem.Value;
            }

            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void drpnewdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                properties.DropNewDept = drpnewdept.SelectedItem.Value;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        protected void drpexistingfunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                properties.DropExistingFunction = drpexistingfunction.SelectedItem.Value;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        protected void drpnewfunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                properties.DropNewFunction = drpnewfunction.SelectedItem.Value;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}

