using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    abstract class UserController
    {
        UserInfo userInfo;
        public UserController(UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }

        public abstract void ShowUserInterface();
    }
}
