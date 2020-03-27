using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public abstract class ConnectionToSql
    {
         private readonly string connectionString;
       public ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-HMI8KPC\\SQL2019TEST; DataBase=ALROUGI; integrated security=true";
            

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
