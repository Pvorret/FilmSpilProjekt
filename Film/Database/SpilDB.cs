using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Film.Database
{
    public static class SpilDB
    {

        public static string GetTest()
        {
            SqlConnection connect = DBConnection.ConnectToDB();
            string test;

            try
            {
                connect.Open();
                SqlCommand sqlCmd = new SqlCommand("GetTest", connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                reader.Read();
 
                test = Convert.ToString(reader["Name"]);
            
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connect.Close();
                connect.Dispose();
            }
            return test;
        }
    }
}
