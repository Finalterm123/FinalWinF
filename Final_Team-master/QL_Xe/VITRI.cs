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

        public bool updateVTGuibyID(int ID_Xe)
        {
            SqlCommand command = new SqlCommand("UPDATE VT SET Tinh_Trang=1 WHERE ID_VT=@ID_Xe", _Xe.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;

            return check_command(command);
        }

        bool check_command(SqlCommand command)
        {
            _Xe.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            _Xe.closeConnection();
            return result;
        }
    }
}
