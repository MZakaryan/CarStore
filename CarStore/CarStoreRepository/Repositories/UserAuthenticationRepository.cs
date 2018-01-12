using CarStoreInfo;
using CarStoreRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CarStoreRepository
{
    public class UserAuthenticationRepository
    {

        public bool IsUserDataValid(UserLoginInfo userLoginInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"Select Login, Password FROM StoreUser " +
                    $"WHERE Login = '{userLoginInfo.Login}' AND Password = '{userLoginInfo.Password}'";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public UserInfo Import(UserLoginInfo userLoginInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"Select * FROM StoreUser " +
                    $"WHERE Login = '{userLoginInfo.Login}' AND Password = '{userLoginInfo.Password}'";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new UserInfo()
                    {
                        ID = (int)reader["ID"],
                        Login = reader["Login"].ToString(),
                        Password = reader["Password"].ToString(),
                        HasAdminPermission = (bool)reader["HasAdminPermission"]
                    };
                }
                return null;
            }
        }

        public bool LoginExists(string login)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"Select Login, Password FROM StoreUser " +
                    $"WHERE Login = '{login}'";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool Export(UserRegistrationInfo userRegistrationInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string sqlCommand = $"INSERT INTO StoreUser(Login, Password, HasAdminPermission) " +
                    $"VALUES('{userRegistrationInfo.Login}','{userRegistrationInfo.Password}'," +
                    $"'{userRegistrationInfo.HasAdminPermission}')";

                SqlCommand command = new SqlCommand(sqlCommand, connection);

                connection.Open();

                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected != 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
