using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Xe
{
    internal class Xe
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertXe(int ID_Xe, string So_Bien_So, string Loai_Xe, MemoryStream Hinh, string Tinh_Trang)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Xe (ID_Xe, So_Bien_So, Loai_Xe, Hinh, Tinh_Trang)" +
                "VALUES (@ID_Xe,@So_Bien_So, @Loai_Xe , @Hinh, @Tinh_Trang)", mydb.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            command.Parameters.Add("@So_Bien_So", SqlDbType.VarChar).Value = So_Bien_So;
            command.Parameters.Add("@Loai_Xe", SqlDbType.NVarChar).Value = Loai_Xe;
            command.Parameters.Add("@Hinh", SqlDbType.Image).Value = Hinh.ToArray();
            command.Parameters.Add("@Tinh_Trang", SqlDbType.NVarChar).Value = Tinh_Trang;
            return check_command(command);
        }
        public bool updateXebyID(int ID_Xe, string So_Bien_So, string Loai_Xe, MemoryStream Hinh, string Tinh_Trang)
        {
            SqlCommand command = new SqlCommand("UPDATE Xe SET So_Bien_So = @So_Bien_So, Loai_Xe = @Loai_Xe, Hinh = @Hinh, Tinh_Trang=@Tinh_Trang WHERE ID_Xe=@ID_Xe", mydb.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            command.Parameters.Add("@So_Bien_So", SqlDbType.VarChar).Value = So_Bien_So;
            command.Parameters.Add("@Loai_Xe", SqlDbType.NVarChar).Value = Loai_Xe;
            command.Parameters.Add("@Hinh", SqlDbType.Image).Value = Hinh.ToArray();
            command.Parameters.Add("@Tinh_Trang", SqlDbType.NVarChar).Value = Tinh_Trang;

            return check_command(command);
        }
        public bool updateXebyIDnBS(int ID_Xe, string So_Bien_So, string Loai_Xe, MemoryStream Hinh, string Tinh_Trang)
        {
            SqlCommand command = new SqlCommand("UPDATE Xe SET Loai_Xe = @Loai_Xe, Hinh = @Hinh, Tinh_Trang=@Tinh_Trang WHERE ID_Xe=@ID_Xe and So_Bien_So = @So_Bien_So", mydb.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            command.Parameters.Add("@So_Bien_So", SqlDbType.VarChar).Value = So_Bien_So;
            command.Parameters.Add("@Loai_Xe", SqlDbType.NVarChar).Value = Loai_Xe;
            command.Parameters.Add("@Hinh", SqlDbType.Image).Value = Hinh.ToArray();
            command.Parameters.Add("@Tinh_Trang", SqlDbType.NVarChar).Value = Tinh_Trang;

            return check_command(command);
        }
        public bool deleteXe(int ID_Xe)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Xe WHERE ID_Xe = @ID_Xe", mydb.getConnection);

            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getXeById(int ID_Xe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xe WHERE ID_Xe=@ID_Xe", mydb.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistXe(int ID_Xe = 0, string So_Bien_So = "")
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xe WHERE ID_Xe = @ID_Xe or So_Bien_So = @So_Bien_So", mydb.getConnection);
            command.Parameters.Add("@ID_Xe", SqlDbType.Int).Value = ID_Xe;
            command.Parameters.Add("@So_Bien_So", SqlDbType.VarChar).Value = So_Bien_So;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable listXetoSelect(string loaiXe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xe WHERE Loai_Xe = @loaiXe", mydb.getConnection);
            command.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaiXe;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable selectXeList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
