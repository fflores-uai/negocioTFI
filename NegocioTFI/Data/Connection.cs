using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Connection : IConnection
    {
        private SqlConnection cnn;
        private DataSet dataset;
        private SqlTransaction tr;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public Connection()
        {
            dataset = new DataSet();
            cmd = new SqlCommand();
            cnn = new SqlConnection(System.Configuration.ConfigurationManager
                                          .ConnectionStrings["DataContext"]
                                          .ConnectionString);
        }

        public DataSet Read(string query, Hashtable data)
        {
            cmd.Connection = cnn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;

            AddParameters(data);

            da = new SqlDataAdapter();
            da.Fill(dataset);

            return dataset;
        }

        public bool Write(string query, Hashtable data)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            try
            {
                tr = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tr;

                AddParameters(data);

                cmd.ExecuteNonQuery();

                tr.Commit();
                return true;
            }
            catch (System.Exception)
            {
                tr.Rollback();
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }

        private void AddParameters(System.Collections.Hashtable data)
        {
            if (data != null)
            {
                foreach (string d in data.Keys)
                {
                    cmd.Parameters.AddWithValue(d, data[d]);
                }
            }
        }
    }
}