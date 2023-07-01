using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1
{
    internal class databaseconnect
    {
        SqlConnection con = new SqlConnection("server =KP_HARISH\\SQLEXPRESS;Initial Catalog = projectwork ;Integrated Security=true;");

    
           public int addproduct(int @productid, string @productname,string @productdescription)
        {
            SqlCommand cmd = new SqlCommand("insertproduct ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@productname",productname );
            cmd.Parameters.AddWithValue("@productdescription",productdescription);
          
            int x = cmd.ExecuteNonQuery();
            con.Close();
          
            return x;
        }
           
        public DataTable viewfulltable()
        {
            SqlCommand cmd = new SqlCommand("showfulltable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

        public DataTable viewtablebyid(int productid)
        {
            SqlCommand cmd = new SqlCommand("showtablebyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

        public int editproduct(int @productid, string @productname, string @productdescription)
        {
            SqlCommand cmd = new SqlCommand("updateproduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@productdescription", productdescription);

            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }

        public int deleteproductbyid(int @productid)
        {
            SqlCommand cmd = new SqlCommand("deletetablebyid ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@productid", productid);
           

            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }

        public int deletemodelbyid(int @modelid)
        {
            SqlCommand cmd = new SqlCommand("deletetablebymodelid ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@modelid", modelid);


            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }

        public int addmodel(int @productid, string @productname,int modelid,string modelname,string specification,int unitprice,int stockonhand)
        {
            SqlCommand cmd = new SqlCommand("insertmodel ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@modelid", modelid);
            cmd.Parameters.AddWithValue("@modelname", modelname);
            cmd.Parameters.AddWithValue("@specification", specification);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@stockonhand", stockonhand);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int editmodel(int modelid, string modelname, string specification, int unitprice, int stockonhand)
        {
            SqlCommand cmd = new SqlCommand("updatemodel ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            
            cmd.Parameters.AddWithValue("@modelid", modelid);
            cmd.Parameters.AddWithValue("@modelname", modelname);
            cmd.Parameters.AddWithValue("@specification", specification);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@stockonhand", stockonhand);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }


        public DataTable viewfulltablemodel()
        {
            SqlCommand cmd = new SqlCommand("showfulltablemodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
            
        }


        public DataTable modelreport()
        {
            SqlCommand cmd = new SqlCommand("modelreport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }

        public DataTable viewfulltableuser()
        {
            SqlCommand cmd = new SqlCommand("showlfulltableuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
            
        }

        public DataTable viewtablebymodelid(int modelid)
        {
            SqlCommand cmd = new SqlCommand("showtablebymodelid ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@modelid", modelid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int logintype(string @userid, string @password, string @usertype)
        {
            SqlCommand cmd = new SqlCommand("allowuser ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@usertype", usertype);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int x= int.Parse(dr[0].ToString());
            con.Close();
            return x;
        }

        public int recordsales(int @productid , string @productname ,int @modelid ,string @modelname ,string @specification ,int @unitprice, int @quantity ,int @totalamount,string @userid )
        {
            SqlCommand cmd = new SqlCommand("recordsales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@modelid", modelid);
            cmd.Parameters.AddWithValue("@modelname", modelname);
            cmd.Parameters.AddWithValue("@specification", specification);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@totalamount", totalamount);
            cmd.Parameters.AddWithValue("@userid", userid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int adduser(string userid ,string password, string usertype)
        {
            SqlCommand cmd = new SqlCommand("insertuser ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@password",password);
            cmd.Parameters.AddWithValue("@usertype", usertype);

            int x = cmd.ExecuteNonQuery();
            con.Close();
          
            return x;
        }


        public int edituser(string userid, string password, string usertype)
        {
            SqlCommand cmd = new SqlCommand("updateuser ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@usertype", usertype);

            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }
        public int deleteuserbyid(string @userid)
        {
            SqlCommand cmd = new SqlCommand("deleteuserbyid ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@userid", userid);


            int x = cmd.ExecuteNonQuery();
            con.Close();

            return x;
        }


        public DataTable dailyreport()
        {
            SqlCommand cmd = new SqlCommand("select * from sales where billdate =cast(getdate() as date) ", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable salesreport()
        {
            SqlCommand cmd = new SqlCommand("select * from sales", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable salesreportbtwn(DateTime startdate,DateTime enddate)
        {
            SqlCommand cmd = new SqlCommand("salesreportbtwn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@enddate", enddate);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

    }

}
