﻿using System;
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

        public string role = "";

        public string username = "";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }

        // Phương thức SetConnectionString để thiết lập chuỗi kết nối từ các lớp khác:
        [Obsolete]
        public void SetConnectionString(string connectionString)
        {
            // Set lại connection string
            connectionSTR = connectionString;

            // Kiểm tra thử xem chuỗi này kết nối được không
            OracleConnection connection = new OracleConnection(connectionSTR);

            connection.Open();
            try
            {
                // Truy vấn để lấy dữ liệu từ bảng NHANVIEN
                string query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Kiểm tra xem có dữ liệu và cột role tồn tại không
                if (data.Rows.Count > 0 && data.Columns.Contains("VAITRO"))
                {
                    // Gán giá trị của cột role vào thuộc tính role của lớp DataProvider
                    role = data.Rows[0]["VAITRO"].ToString();
                    username = data.Rows[0]["MANV"].ToString();
                }
                else
                {
                    // Xử lý khi không tìm thấy dữ liệu hoặc cột role
                    role = "admin"; // hoặc gán giá trị mặc định khác
                    username = "MYADMIN";

                }
            }
            catch (Exception)
            {
                role = "";
            }
           
            connection.Close();
        }

        // Cái này dùng cho truy vấn trả về dạng table
        [Obsolete]
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
                try
                {
                    adapter.Fill(data);
                }
                catch (Exception)
                {
                    connection.Close();
                    return new DataTable();
                }
               

                connection.Close();
            }
            return data;
        }

        // Cái này dùng cho insert, update, delete --> nó trả về số dòng thực thi thành công 
        [Obsolete]
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
                //try
                //{
                //    data = command.ExecuteNonQuery();
                //}
                //catch(Exception)
                //{
                //    return data;
                //}
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        [Obsolete]
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
        [Obsolete]
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

        [Obsolete]
        public string GetDbmsOutput()
        {
            string output = "";

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "BEGIN DBMS_OUTPUT.GET_LINE(:output, :status); END;";

                    OracleParameter paramOutput = new OracleParameter("output", OracleType.VarChar, 32767);
                    paramOutput.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramOutput);

                    OracleParameter paramStatus = new OracleParameter("status", OracleType.Int32);
                    paramStatus.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramStatus);

                    // Set buffer size for DBMS_OUTPUT
                    command.ExecuteNonQuery();

                    output = paramOutput.Value.ToString();
                }

                connection.Close();
            }

            return output;
        }

    }
}
