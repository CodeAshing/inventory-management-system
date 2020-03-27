using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using common.Cache;


namespace Data
{
    public class userdao :ConnectionToSql
    {
         public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using  (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass );
                    command.Parameters.AddWithValue("@id", userlogincache.Iduser);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userlogincache.Iduser = reader.GetInt32(0);
                            userlogincache.FirstNAme = reader.GetString(3);
                            userlogincache.LastNAme = reader.GetString(4);

                            userlogincache.Position= reader.GetString(5);

                            userlogincache.Email = reader.GetString(6);
                        }
                        return true;    

                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
