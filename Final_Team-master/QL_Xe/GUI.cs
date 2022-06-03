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
            sqlCommand.Parameters.Add("@idGui", SqlDbType.Int).Value = idG;
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

        public DataTable getAllGui()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Gui inner join Xe on Xe.ID_Xe = Gui.ID_Xe " +
                "where Tinh_Trang = N'Đang gửi'", _Xe.getConnection);

            _Xe.openConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            return dataTable;


        }

        public DataTable getAllDaTra()
        {
            SqlCommand sqlCommand = new SqlCommand("select ID_HDG,Hinh_Nguoi_Gui,Loai_Xe,Loai_Hinh_Gui,Start_Time,End_Time,Phi,Phat from Gui inner join Xe on Xe.ID_Xe = Gui.ID_Xe where Tinh_Trang = N'Đã trả'", _Xe.getConnection);

            _Xe.openConnection();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            return dataTable;


        }

        public float getTotalChiphibyIdGui(int idG)
        {
            SqlCommand command = new SqlCommand("select SUM(Chi_Phi) from Gui inner join SD_Dich_Vu SDV on Gui.ID_DV = SDV.ID_DV inner join Chuyen_Mon CM on SDV.id_CM = CM.id_CM where ID_HDG = @idG", _Xe.getConnection);
            command.Parameters.Add("@idG", SqlDbType.Int).Value = idG;

            DataTable da = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(da);
            try
            {

                if (da == null) return 0;
                else return (float)Convert.ToDouble(da.Rows[0][0]);

            }
            catch { return 0; }
        }

        public bool updateEndTime(int idG)
        {
            SqlCommand command = new SqlCommand("UPDATE Gui SET End_Time = getdate() WHERE ID_HDG=@id", _Xe.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idG;

            return check_command(command);


        }

        public bool updateIdDV(int idG, int idDV)
        {
            SqlCommand command = new SqlCommand("UPDATE Gui SET ID_DV = @idDV WHERE ID_HDG=@id", _Xe.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idG;
            command.Parameters.Add("@idDV", SqlDbType.Int).Value = idDV;


            return check_command(command);


        }

        bool check_command(SqlCommand command)
        {
            _Xe.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            _Xe.closeConnection();
            return result;
        }

        /*        public bool updateTTGuibyID(int ID_Xe)
                {
                    SqlCommand command = new SqlCommand("UPDATE Gui SET Tinh_Trang=N'Đang gửi' WHERE ID_HDG=@ID_Xe", _Xe.getConnection);
                    command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;

                    return check_command(command);
                }*/


    }
}
