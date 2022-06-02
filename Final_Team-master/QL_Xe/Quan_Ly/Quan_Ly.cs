using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Quan_Ly
{
    internal class Quan_Ly
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertQL(int id_QL, string Ho_QL, string Ten_QL, string Gioi_Tinh, string Ten_Dang_Nhap, string Mat_Khau, string Email, MemoryStream Anh)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Quan_Ly (id_QL, Ho_QL, Ten_QL, Gioi_Tinh, Ten_Dang_Nhap, Mat_Khau, Email, Anh)" +
                "VALUES (@id_QL, @Ho_QL, @Ten_QL, @Gioi_Tinh, @Ten_Dang_Nhap, @Mat_Khau, @Email , @Anh)", mydb.getConnection);
            command.Parameters.Add("@id_QL", SqlDbType.Int).Value = id_QL;
            command.Parameters.Add("@Ho_QL", SqlDbType.NVarChar).Value = Ho_QL;
            command.Parameters.Add("@Ten_QL", SqlDbType.NVarChar).Value = Ten_QL;
            command.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = Gioi_Tinh;
            command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.VarChar).Value = Ten_Dang_Nhap;
            command.Parameters.Add("@Mat_Khau", SqlDbType.VarChar).Value = Mat_Khau;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@Anh", SqlDbType.Image).Value = Anh.ToArray();
            return check_command(command);
        }
        public bool updateQL(int id_QL, string Ho_QL, string Ten_QL, string Gioi_Tinh, string Ten_Dang_Nhap, string Mat_Khau, string Email, MemoryStream Anh)
        {
            SqlCommand command = new SqlCommand("UPDATE Quan_Ly SET Ho_QL= @Ho_QL, Ten_QL = @Ten_QL, Gioi_Tinh = @Gioi_Tinh, " +
                "Ten_Dang_Nhap = @Ten_Dang_Nhap, Mat_Khau = @Mat_Khau, Email = @Email , Anh = @Anh WHERE id_QL=@id_QL", mydb.getConnection);
            command.Parameters.Add("@id_QL", SqlDbType.Int).Value = id_QL;
            command.Parameters.Add("@Ho_QL", SqlDbType.NVarChar).Value = Ho_QL;
            command.Parameters.Add("@Ten_QL", SqlDbType.NVarChar).Value = Ten_QL;
            command.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = Gioi_Tinh;
            command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.VarChar).Value = Ten_Dang_Nhap;
            command.Parameters.Add("@Mat_Khau", SqlDbType.VarChar).Value = Mat_Khau;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@Anh", SqlDbType.Image).Value = Anh.ToArray();

            return check_command(command);
        }
        public bool deleteQL(int id_QL)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Quan_Ly WHERE id_QL = @id_QL", mydb.getConnection);

            command.Parameters.Add("@id_QL", SqlDbType.Int).Value = id_QL;
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
        public DataTable getQLById(int id_QL)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Quan_Ly WHERE id_QL=@id_QL", mydb.getConnection);

            command.Parameters.Add("@id_QL", SqlDbType.NVarChar).Value = id_QL;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistQL(int id_QL, string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Quan_Ly WHERE id_QL = @id_QL OR userName = @userName", mydb.getConnection);
            command.Parameters.Add("@id_QL", SqlDbType.Int).Value = id_QL;
            command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;

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
    }
}
