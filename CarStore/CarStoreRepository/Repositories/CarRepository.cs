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
    public class CarRepository
    {
        public bool Export(CarInfo carInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"INSERT INTO Car(Price, ColorName, ModelID, IsDeleted) " +
                    $"VALUES ('{carInfo.Price}', '{carInfo.ColorName}', '{carInfo.ModelId}', '{carInfo.IsDeleted}')";

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

        public List<CarListViewModel> Import(int modelId, bool isDeleted = false)
        {
            List<CarListViewModel> carList = new List<CarListViewModel>();
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = "SELECT Brand.Name AS 'Brand', Model.Name AS 'Model', Car.ID, Car.Price, Car.ColorName, Car.IsDeleted " +
                             "FROM Brand " +
                             "INNER JOIN Model ON Brand.ID = Model.BrandID " +
                             "INNER JOIN Car ON Model.ID = Car.ModelID " +
                             $"WHERE Car.ModelID = '{modelId}' AND Car.IsDeleted = '{isDeleted}'";

                SqlCommand command = new SqlCommand(str, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        carList.Add(new CarListViewModel()
                        {
                            ID = (int)reader["ID"],
                            BrandName = reader["Brand"].ToString(),
                            ModelName = reader["Model"].ToString(),
                            Price = (int)reader["Price"],
                            ColorName = reader["ColorName"].ToString(),
                            IsDeleted = (bool)reader["IsDeleted"]
                        });
                    }
                }
            }
            return carList;
        }

        public bool Update(CarInfo carInfo)
        {
            using (SqlConnection connection = new SqlConnection(Util.ConnectionString))
            {
                string str = $"UPDATE Car SET Price = '{carInfo.Price}', ColorName = '{carInfo.ColorName}', IsDeleted = '{carInfo.IsDeleted}' WHERE ID = '{carInfo.ID}'";

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
    }
}
