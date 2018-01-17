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
    public class ModelRepository
    {
        public bool Export(ModelInfo modelInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"INSERT INTO Model(Name, BrandID) " +
                    $"VALUES ('{modelInfo.Name}', '{modelInfo.BrandId}')";

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

        public List<ModelInfo> Import()
        {
            List<ModelInfo> modelList = new List<ModelInfo>();

            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"SELECT * FROM Model";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        modelList.Add(new ModelInfo()
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            BrandId = (int)reader["BrandID"]
                        });
                    }
                }

            }

            return modelList;
        }
    }
}
