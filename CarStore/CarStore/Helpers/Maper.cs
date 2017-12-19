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
        public static UserLoginInfo MapingLoginInfo(string login, string pass)
        {
            return new UserLoginInfo()
            {
                Login = login,
                Password = pass
            };
        }



    }
}
