using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreRepository.Repositories
{
    public class BrandRepository
    {
        public bool Export(BrandInfo brandInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"INSERT INTO Brand(Name) VALUES ('{brandInfo.Name}')";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected != 0)
                {
                    return true;
                }
                return false;
            }
        }

        public List<BrandInfo> Import()
        {
            List<BrandInfo> brandList = new List<BrandInfo>();

            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"SELECT * FROM Brand";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        brandList.Add(new BrandInfo()
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString()
                        });
                    }
                }

            }

            return brandList;
        }
    }
}
