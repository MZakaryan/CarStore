using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Helpers
{
    static class ValidationHelper
    {
        public static bool IsLoginFieldsCompleted(UserLoginInfo userLoginInfo)
        {
            userLoginInfo.Login = userLoginInfo.Login.Trim();
            userLoginInfo.Password = userLoginInfo.Password.Trim();

            return (!string.IsNullOrEmpty(userLoginInfo.Login))
                && (!string.IsNullOrEmpty(userLoginInfo.Password));
        }

        public static bool IsCarValid(CarInfo carInfo)
        {
            return true ? carInfo.ModelId != 0 : false;
        }

        public static bool IsModelNameValid(ModelInfo modelInfo)
        {
            return !string.IsNullOrEmpty(modelInfo.Name);
        }

        public static bool IsBrandNameValid(BrandInfo brandInfo)
        {
            return !string.IsNullOrEmpty(brandInfo.Name);
        }

        public static bool IsRegFieldsCompleted(UserRegistrationInfo userRegInfo)
        {
            userRegInfo.Login = userRegInfo.Login.Trim();
            userRegInfo.Password = userRegInfo.Password.Trim();
            userRegInfo.ConfirmPassword = userRegInfo.ConfirmPassword.Trim();

            return !(string.IsNullOrEmpty(userRegInfo.Login))
                && !(string.IsNullOrEmpty(userRegInfo.Password))
                && !(string.IsNullOrEmpty(userRegInfo.ConfirmPassword));
        }

        public static bool IsPasswordSame(string pass, string confPass)
        {
            return pass == confPass;
        }
    }
}
