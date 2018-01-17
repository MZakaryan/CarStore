using CarStore.Helpers;
using CarStoreInfo;
using CarStoreRepository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class CarController
    {
        private CarRepository _carRepository;

        public CarController()
        {
            _carRepository = new CarRepository();
        }


        public bool Add(CarInfo carInfo)
        {
            bool isValid = ValidationHelper.IsCarValid(carInfo);
            if (isValid)
            {
                if (!_carRepository.Export(carInfo))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public bool Update(CarInfo carInfo)
        {
            return _carRepository.Update(carInfo);
        }

        public List<CarListViewModel> Get(int modelId)
        {
            return _carRepository.Import(modelId);
        }
    }
}
