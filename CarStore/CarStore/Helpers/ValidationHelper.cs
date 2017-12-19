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
    }
}
