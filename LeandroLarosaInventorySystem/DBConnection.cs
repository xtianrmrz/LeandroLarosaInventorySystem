using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LeandroLarosaInventorySystem
{
    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        //DBConnection dbcon = new DBConnection();
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-O8OCA4G;Initial Catalog=LeandroLarosaDB;Integrated Security=True";
            return con;
        }

        public double GetVal()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("Select * from tblVat", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            cn.Close();
            return vat;
        }


    }
}
