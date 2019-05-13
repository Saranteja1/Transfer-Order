using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PAL_properties_;


namespace DAL_InterConnection_
{
    public class DAL
    {
        PAL properties = new PAL();
        SqlConnection conn; SqlCommand cmd; SqlDataAdapter da;
        string constr = ConfigurationManager.ConnectionStrings["Connection"].ToString();
        DataSet ds = new DataSet();

        //sP for Login
        public DataSet Login(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_Login", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Staffno", properties.StaffNumber);
                cmd.Parameters.AddWithValue("@Password", properties.Password);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //sP for Dropdown(immedaiteSupervisor)
        public DataSet DropDownDal(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_dropdownlistforDropdownImmSupervisor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ImmedaiteSupervisor", properties.StaffNumber);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //sP for Selecting Dropdown
        public DataSet SelectDropDownDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_immedaiteSupSelectemp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Staffno", properties.EmployeeNumberorName);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //proj
        public DataSet DropDownProjectDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_project", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //dept
        public DataSet DropDownDepartmentDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_department", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //function
        public DataSet DropDownFunctionDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_Function", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //InsertImmediateSupervisorDAL
        public void InsertImmediateDAL(PAL properties)
        {

            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_insertimmedsup", conn);
                cmd.CommandType =System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staffnumber", properties.StaffNumber);
                cmd.Parameters.AddWithValue("@Name", properties.ImmedaiteFormName);
                cmd.Parameters.AddWithValue("@Department", properties.ImmedaiteFormDept);
                cmd.Parameters.AddWithValue("@Desgination", properties.ImmedaiteFormDesgination);
                cmd.Parameters.AddWithValue("@Location", properties.ImmedaiteFormLocation);
                cmd.Parameters.AddWithValue("@Cluster", properties.ImmedaiteFormCluster);
                cmd.Parameters.AddWithValue("@Email", properties.ImmedaiteFormEmailadress);
                cmd.Parameters.AddWithValue("@Adress", properties.ImmedaiteFormAdress);
                cmd.Parameters.AddWithValue("@ImmedaiteSup", properties.ImmedaiteFormImmedaiteSup);
                cmd.Parameters.AddWithValue("@UplineSup", properties.ImmedaiteFormUplineSup);
                cmd.Parameters.AddWithValue("@SelectProcess", properties.DropDownSelectionProcess);
                cmd.Parameters.AddWithValue("@ExistingProject", properties.DropdownExistingProject);
                cmd.Parameters.AddWithValue("@NewProject", properties.DropdownNewProject);
                cmd.Parameters.AddWithValue("@ExistingDept", properties.DropExistingDept);
                cmd.Parameters.AddWithValue("@NewDept", properties.DropNewDept);
                cmd.Parameters.AddWithValue("@ExistingFunction", properties.DropExistingFunction);
                cmd.Parameters.AddWithValue("@NewFunction", properties.DropNewFunction);
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        //Update
        public void UpdateImmediateDAL(PAL properties)
        {

            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_updateimmedsup", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staffnumber", properties.StaffNumber);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //ViewScreen
   
        public DataSet DropDownViewScreenDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("Sp_View", conn);
                cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@Action", "Select");
               cmd.Parameters.AddWithValue("@staffnumber", "");
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            
        }
        
         public DataSet DropDownViewDropDownScreenDAL(PAL properties)
        {
            try
            {
                ds = new DataSet();
                conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("Sp_View", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "SelectingValuesfordataset");
                cmd.Parameters.AddWithValue("@staffnumber", properties.StaffNumber);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }










    }
}
