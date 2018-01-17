using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Helpers
{
    static class Maper
    {
        public static UserRegistrationInfo MapingRegistrationInfo(string login, string pass, string confimPas)
        {
            return new UserRegistrationInfo()
            {
                Login = login,
                Password = pass,
                ConfirmPassword = confimPas
            };
        }

        public static UserLoginInfo MapingLoginInfo(string login, string pass)
        {
            return new UserLoginInfo()
            {
                Login = login,
                Password = pass
            };
        }

        public static CarInfo MapingCarViewModel(CarListViewModel carListViewModel)
        {
            return new CarInfo()
            {
                ID = carListViewModel.ID,
                Price = carListViewModel.Price,
                ColorName = carListViewModel.ColorName,
                //ModelId = carListViewModel.ModelName
                IsDeleted = carListViewModel.IsDeleted
            };
        }

    }
}
