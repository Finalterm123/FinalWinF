using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Tho
{
    internal class Tho
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertTho(int ID_Tho,string Ten_Tho,DateTime NgSinh, string Gioi_Tinh, string Phone, MemoryStream Anh,  int ID_CM)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Tho (ID_Tho,Ten_Tho, NgSinh, Gioi_Tinh,Phone, Anh, ID_CM)" +
                "VALUES (@ID_Tho,@Ten_Tho,@NgSinh, @Gioi_Tinh ,@Phone, @Anh, @ID_CM)", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
            command.Parameters.Add("@Ten_Tho", SqlDbType.NVarChar).Value = Ten_Tho;
            command.Parameters.Add("@NgSinh", SqlDbType.Date).Value = NgSinh;
            command.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = Gioi_Tinh;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            command.Parameters.Add("@Anh", SqlDbType.Image).Value = Anh.ToArray();
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;
            return check_command(command);
        }
        public bool updateThobyID(int ID_Tho, string Ten_Tho, DateTime NgSinh, string Gioi_Tinh, string Phone, MemoryStream Anh, int ID_CM)
        {
            SqlCommand command = new SqlCommand("UPDATE Tho SET ID_Tho=@ID_Tho,Ten_Tho =@Ten_Tho,NgSinh=@NgSinh, Gioi_Tinh=@Gioi_Tinh ,Phone=@Phone, Anh=@Anh, ID_CM=@ID_CM WHERE ID_Tho=@ID_Tho", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
            command.Parameters.Add("@Ten_Tho", SqlDbType.NVarChar).Value = Ten_Tho;
            command.Parameters.Add("@NgSinh", SqlDbType.Date).Value = NgSinh;
            command.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = Gioi_Tinh;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            command.Parameters.Add("@Anh", SqlDbType.Image).Value = Anh.ToArray();
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;

            return check_command(command);
        }
        public bool updateThobyIDnSDT(int ID_Tho, string Ten_Tho, DateTime NgSinh, string Gioi_Tinh, string Phone, MemoryStream Anh, int ID_CM)
        {
            SqlCommand command = new SqlCommand("UPDATE Tho SET ID_Tho=@ID_Tho,Ten_Tho =@Ten_Tho,NgSinh=@NgSinh, Gioi_Tinh=@Gioi_Tinh, Anh=@Anh, ID_CM=@ID_CM WHERE ID_Tho=@ID_Tho and Phone=@Phone", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
            command.Parameters.Add("@Ten_Tho", SqlDbType.NVarChar).Value = Ten_Tho;
            command.Parameters.Add("@NgSinh", SqlDbType.Date).Value = NgSinh;
            command.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = Gioi_Tinh;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            command.Parameters.Add("@Anh", SqlDbType.Image).Value = Anh.ToArray();
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;

            return check_command(command);
        }
        public bool deleteTho(int ID_Tho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Tho WHERE ID_Tho = @ID_Tho", mydb.getConnection);

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
        public DataTable getThoById(int ID_Tho)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE ID_Tho=@ID_Tho", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistID(int ID_Tho)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE ID_Tho = @ID_Tho ", mydb.getConnection);
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;

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
        public bool checkExistSDT(string Phone)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE Phone like @Phone ", mydb.getConnection);
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = Phone;

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
        public bool checkExistIDnSDT(int ID_Tho, string Phone)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tho WHERE ID_Tho = @ID_Tho and Phone like @Phone ", mydb.getConnection);
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@ID_Tho", SqlDbType.Int).Value = ID_Tho;

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
        public DataTable selectThoList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
