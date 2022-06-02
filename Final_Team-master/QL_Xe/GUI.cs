using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    internal class GUI
    {
        QL_Xe _Xe = new QL_Xe();

        public bool insertGui(int idG, MemoryStream Hinh_NgGui, int idXe, int idVT, int idTho, int idDV, DateTime sd, string loaihinhGui, float phi, float phat, string mota)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Gui(id_hdg, hinh_nguoi_gui, id_xe, id_vt, id_tho, id_dv, start_time, loai_hinh_gui, phi, phat, mo_ta) " +
                " values (@idGui,@hinhngGui,@idXe,@idVT,@idTho,@idDV,@sd,@loaiGui,@phi,@phat,@mota)", _Xe.getConnection);
            sqlCommand.Parameters.Add("@idGui",SqlDbType.Int).Value = idG;
            sqlCommand.Parameters.Add("@hinhngGui", SqlDbType.Image).Value = Hinh_NgGui.ToArray();
            sqlCommand.Parameters.Add("@idXe", SqlDbType.Int).Value = idXe;
            sqlCommand.Parameters.Add("@idVT", SqlDbType.Int).Value = idVT;
            sqlCommand.Parameters.Add("@idTho", SqlDbType.Int).Value = idTho;
            sqlCommand.Parameters.Add("@idDV", SqlDbType.Int).Value = idDV;
            sqlCommand.Parameters.Add("@sd", SqlDbType.DateTime).Value = sd;
            //sqlCommand.Parameters.Add("@ed", SqlDbType.DateTime).Value = ed;
            sqlCommand.Parameters.Add("@loaiGui", SqlDbType.NVarChar).Value = loaihinhGui;
            sqlCommand.Parameters.Add("@phi", SqlDbType.Float).Value = phi;
            sqlCommand.Parameters.Add("@phat", SqlDbType.Float).Value = phat;
            sqlCommand.Parameters.Add("@mota", SqlDbType.Text).Value = mota;

            _Xe.openConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
    }
}
