using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QL_Xe
{
    internal class VITRI
    {
        QL_Xe _Xe = new QL_Xe();

        public DataTable getVitri(int opt)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT ID_VT as Location, Tinh_Trang as Status FROM VT WHERE Loai_VT = @opt and Tinh_Trang = 0", _Xe.getConnection);
            sqlCommand.Parameters.Add("@opt",SqlDbType.Int).Value = opt;

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
