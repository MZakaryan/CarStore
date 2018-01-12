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
    class AdminController : UserController
    {
        public AdminController(UserInfo userInfo) : base(userInfo)
        {
        }
        
        public override void ShowUserInterface(out DialogResult dialogResult)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
            dialogResult = formAdmin.DialogResult;
        }
    }
}
