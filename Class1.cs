using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectMars
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public string a;
       public string b;
        public Database()

        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=ruxian\\SQL2016ADV;Initial Catalog=POS;Integrated Security=True";
        }
        public void openCon()
        {
            con.Open();
        }
        public void closeCon()
        {
            con.Close();
        }
        public void singleData(string query)
        {
            string[] firstVariable = new string[2];
          //  string secondVariable = string.Empty;
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con)) 
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                a = reader[0].ToString();
                                b = reader[1].ToString();


                        }
                        }
                    cmd.Dispose();
                    con.Close();
                    }
                }
            
            catch (Exception)
            {
                MessageBox.Show("ERRRO");//test!
            }
            
        }
        public DataTable getData(string query)
        {
            try
            {
                openCon();
            }
            catch(SqlException)
            {
                MessageBox.Show("Cheack database connection");//Neeed to modify!
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
             da.Fill(dt);
            closeCon();
            return dt;
        }
    }
}
