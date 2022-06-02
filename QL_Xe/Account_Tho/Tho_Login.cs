using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Account_Tho
{
    internal class Tho_Login
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertAcc(int ID_Tho, string Ten_Dang_Nhap, string Mat_Khau, string Email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Tho_Login (ID_Tho, Ten_Dang_Nhap, Mat_Khau, Email)" +
                "VALUES (@ID_Tho, @Ten_Dang_Nhap, @Mat_Khau, @Email)", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
            command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.VarChar).Value = Ten_Dang_Nhap;
            command.Parameters.Add("@Mat_Khau", SqlDbType.VarChar).Value = Mat_Khau;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
            return check_command(command);
        }
        public bool deleteAcc(int ID_Tho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Tho_Login WHERE ID_Tho = @ID_Tho", mydb.getConnection);

            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
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
        public bool checkExistAccName(string Ten_Dang_Nhap)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho_Login WHERE Ten_Dang_Nhap = @Ten_Dang_Nhap", mydb.getConnection);
            command.Parameters.Add("@Ten_Dang_Nhap", SqlDbType.NVarChar).Value = Ten_Dang_Nhap;

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
        public bool checkExistEmail(string Email)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho_Login WHERE Email = @Email", mydb.getConnection);
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;

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
        public bool checkExistID(int id_QL)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho_Login WHERE ID_Tho = @ID_Tho", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = id_QL;

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
