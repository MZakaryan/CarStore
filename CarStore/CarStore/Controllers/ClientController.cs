using CarStore.Forms;
using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStore.Controllers
{
    class ClientController : UserController
    {
        public ClientController(UserInfo userInfo) : base(userInfo)
        {

        }

        public override void ShowUserInterface(out DialogResult dialogResult)
        {
            FormClient formClient = new FormClient();
            formClient.ShowDialog();
            dialogResult = formClient.DialogResult;
        }
    }
}
