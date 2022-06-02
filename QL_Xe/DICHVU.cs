using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Xe
{
    internal class DICHVU
    {
        QL_Xe _Xe = new QL_Xe();
        
        public bool insertDV(int id, int idGui,int idCM)
        {
            SqlCommand cmd = new SqlCommand("insert into SD_Dich_Vu values (@id,@idGui,@idCM)",_Xe.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@idGui", SqlDbType.Int).Value = idGui;
            cmd.Parameters.Add("@idCM", SqlDbType.Int).Value = idCM;

            _Xe.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                _Xe.closeConnection();
                return true;
            }
            else
            {
                _Xe.closeConnection();
                return false;
            }

        }

        public int getMaxIdDV()
        {
            SqlCommand cmd = new SqlCommand("select max(ID_DV) from SD_Dich_Vu", _Xe.getConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0] is DBNull)
            {
                dataTable.Rows[0][0] = 1;
            }

            return Convert.ToInt32( dataTable.Rows[0][0]);
        }

        public DataTable  getCurDataDV(string loai_xe)
        {
            SqlCommand sqlCommand = new SqlCommand("select id_CM,Ten_CM,Mo_Ta from Chuyen_Mon where Loai_xe = @loai", _Xe.getConnection);
            sqlCommand.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loai_xe;
            _Xe.openConnection();
            sqlCommand.ExecuteNonQuery();
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            _Xe.closeConnection();
            adapter.Fill(dt);

            return dt;
        }

    }
}
