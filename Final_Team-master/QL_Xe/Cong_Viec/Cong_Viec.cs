using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Cong_Viec
{
    internal class Cong_Viec
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertCV(int ID_CV, string Ten_CV, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Cong_Viec (ID_CV, Ten_CV, Mo_Ta)" +
                "VALUES (@ID_CV,@Ten_CV, @Mo_Ta )", mydb.getConnection);
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
            command.Parameters.Add("@Ten_CV", SqlDbType.NVarChar).Value = Ten_CV;
            command.Parameters.Add("@Mo_Ta", SqlDbType.NVarChar).Value = Mo_Ta;
            return check_command(command);
        }
        public bool updateCVbyID(int ID_CV, string Ten_CV, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("UPDATE Cong_Viec SET Ten_CV = @Ten_CV, Mo_Ta = @Mo_Ta WHERE ID_CV=@ID_CV", mydb.getConnection);
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
            command.Parameters.Add("@Ten_CV", SqlDbType.NVarChar).Value = Ten_CV;
            command.Parameters.Add("@Mo_Ta", SqlDbType.NVarChar).Value = Mo_Ta;

            return check_command(command);
        }
        public bool updateCVbyIDnName(int ID_CV, string Ten_CV, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("UPDATE Cong_Viec SET Mo_Ta = @Mo_Ta WHERE ID_CV=@ID_CV and Ten_CV= @Ten_CV", mydb.getConnection);
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
            command.Parameters.Add("@Ten_CV", SqlDbType.NVarChar).Value = Ten_CV;
            command.Parameters.Add("@Mo_Ta", SqlDbType.NVarChar).Value = Mo_Ta;

            return check_command(command);
        }
        public bool deleteCV(int ID_CV)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Cong_Viec WHERE ID_CV = @ID_CV", mydb.getConnection);

            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
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
        public DataTable getCVById(int ID_CV)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec WHERE ID_CV=@ID_CV", mydb.getConnection);
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistID(int ID_CV)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec WHERE ID_CV = @ID_CV ", mydb.getConnection);
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;

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
        public bool checkExistName(string Ten_CV)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec WHERE Ten_CV like N'"+ Ten_CV + "'", mydb.getConnection);
            command.Parameters.Add("@Ten_CV", SqlDbType.NVarChar).Value = Ten_CV;

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
        public bool checkExistIDnName(int ID_CV, string Ten_CV)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec WHERE ID_CV = @ID_CV and Ten_CV like N'" + Ten_CV + "' ", mydb.getConnection);
            command.Parameters.Add("@Ten_CV", SqlDbType.NVarChar).Value = Ten_CV;
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;

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
        public DataTable selectCVList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCV()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cong_Viec", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
