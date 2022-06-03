using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    internal class QL_Xe
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NC3S3Q0\SQLEXPRESS;Initial Catalog=QL_Xe;Integrated Security=True");


        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Close();
            }
        }
    }
}
