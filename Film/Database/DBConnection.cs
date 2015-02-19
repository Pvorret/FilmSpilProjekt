using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Film.Database
{
    static class DBConnection
    {
        public static SqlConnection ConnectToDB()
        {
            SqlConnection connect = new SqlConnection(
                "Server=PVLAPTOP\\PHILLIPSSERVER;" +
                "Database=FilmSpilDB;" +
                "User Id=Phil;" +
                "Password=Phil010592"
                );
            return connect;
        }
    }
}
