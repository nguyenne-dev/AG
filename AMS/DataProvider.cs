using System.Data;
using System.Data.SqlClient;

namespace AMS
{
    public class DataProvider
    {
        private string connectString = @"Data Source=Nguyen\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;Encrypt=False";

        public DataTable execQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(connectString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số vào câu truy vấn nếu có
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return data;
        }

        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        public object execScalar(string query)
        {
            object data = null; // Khởi tạo data bằng null thay vì 0
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
