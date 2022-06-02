using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe.Chuyen_Mon
{
    internal class ChuyenMon
    {
        QL_Xe mydb = new QL_Xe();
        bool check_command(SqlCommand command)
        {
            mydb.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            mydb.closeConnection();
            return result;
        }
        public bool insertCM(int ID_CM, string Ten_CM,int ID_CV, string Loai_xe, string Mo_Ta)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Chuyen_Mon (ID_CM, Ten_CM,ID_CV,Loai_xe, Mo_Ta)" +
                "VALUES (@ID_CM,@Ten_CM,@ID_CV,@Loai_xe, @Mo_Ta )", mydb.getConnection);
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;
            command.Parameters.Add("@ID_CV", SqlDbType.Int).Value = ID_CV;
            command.Parameters.Add("@Ten_CM", SqlDbType.NVarChar).Value = Ten_CM;
            command.Parameters.Add("@Loai_xe", SqlDbType.NVarChar).Value = Loai_xe;
            command.Parameters.Add("@Mo_Ta", SqlDbType.NVarChar).Value = Mo_Ta;
            return check_command(command);
        }
        public bool deleteCM(int ID_CM)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Chuyen_Mon WHERE ID_CM = @ID_CM", mydb.getConnection);

            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;
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
        public DataTable getCMById(int ID_CM)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon WHERE ID_CM=@ID_CM", mydb.getConnection);
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkExistID(int ID_CM)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon WHERE ID_CM = @ID_CM ", mydb.getConnection);
            command.Parameters.Add("@ID_CM", SqlDbType.Int).Value = ID_CM;

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
        public bool checkExistName(string Ten_CM)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon WHERE Ten_CM like N'" + Ten_CM + "'", mydb.getConnection);
            command.Parameters.Add("@Ten_CM", SqlDbType.NVarChar).Value = Ten_CM;

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
        public DataTable selectCMList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCM()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Chuyen_Mon", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
