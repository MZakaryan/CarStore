using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    class ClientController : UserController
    {
        public ClientController(UserInfo userInfo) : base(userInfo)
        {

        }

        public override void ShowUserInterface()
        {
            //TODO form load
        }
    }
}
