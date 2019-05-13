using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAL_properties_;
using DAL_InterConnection_;


namespace BAL_DataAcessLayer_
{
    public class BAL
    {
        DataSet ds = new DataSet();
        DAL datacacesslayer = new DAL();
        PAL properties = new PAL();
        public DataSet Login_InterConnection(PAL properties)
        {
            try
            {
                ds = datacacesslayer.Login(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }
        //DropDown For Employee Number Or Name
        public DataSet DropDownBal(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownDal(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }

        //Selecting DropDown
        public DataSet SelectDropDownBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.SelectDropDownDAL(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }
        //Poject
        public DataSet DropDownProjectBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownProjectDAL(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }
        //Function
        public DataSet DropDownFunctionBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownFunctionDAL(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }
        //Insert
        public void InsertImmediateBAL(PAL properties)
        {
            try
            {
               datacacesslayer.InsertImmediateDAL(properties);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
  
        }
        //update
        public void UpdateImmediateBAL(PAL properties)
        {
            try
            {
                datacacesslayer.UpdateImmediateDAL(properties);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
        //dept
        public DataSet DropDownDepartmentBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownDepartmentDAL(properties);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            return ds;
        }
        //ViewScreen
        public DataSet DropDownViewScreenBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownViewScreenDAL(properties);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            return ds;
        }
        public DataSet DropDownViewDropDownScreenBAL(PAL properties)
        {
            try
            {
                ds = datacacesslayer.DropDownViewDropDownScreenDAL(properties);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            return ds;
        }

    }
}
