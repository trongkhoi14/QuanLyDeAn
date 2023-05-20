using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = "";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }

        // Phương thức SetConnectionString để thiết lập chuỗi kết nối từ các lớp khác:
        public void SetConnectionString(string connectionString)
        {
            // Set lại connection string
            connectionSTR = connectionString;

            // Kiểm tra thử xem chuỗi này kết nối được không
            OracleConnection connection = new OracleConnection(connectionSTR);
            connection.Open();
            connection.Close();
        }

        // Cái này dùng cho truy vấn trả về dạng table
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                    
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                OracleDataAdapter adapter = new OracleDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        
        // Cái này dùng cho insert, update, delete --> nó trả về số dòng thực thi thành công 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public void ExecuteOracleProcedure(string procedureName, params OracleParameter[] parameters)
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = procedureName;
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    foreach (OracleParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }

                    // Execute the command
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        // Call the procedure sp_addUser with parameters 'testuser' and 'testpassword'
        // ExecuteOracleProcedure("sp_addUser", new OracleParameter("username", "testuser"), new OracleParameter("password", "testpassword"));
        public int ExecuteProcedureWithOutput(string procedureName, OracleParameter[] parameters)
        {
            int result = 0;
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = procedureName;
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                    result = Convert.ToInt32(command.Parameters["login_success"].Value);
                }
            }
            return result;
        }
    }
}
