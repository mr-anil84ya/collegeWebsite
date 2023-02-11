using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MvcApplication1.Models
{
    public class registration
    {
        public string mycommand { get; set; }
        SqlConnection cn = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=mt;Integrated Security=True");
        public bool ExecuteInsertDeleteUpdate()
        {
            SqlCommand cmd = new SqlCommand(mycommand, cn);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return (cmd.ExecuteNonQuery() > 0 ? true : false);
        }
        public DataTable GetAllData()
        {
            SqlDataAdapter da = new SqlDataAdapter(mycommand, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}