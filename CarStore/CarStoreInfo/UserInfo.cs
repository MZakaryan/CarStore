using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInfo
{
    public class UserLoginInfo
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserInfo : UserLoginInfo
    {
        public Guid UserId { get; set; }

        public bool HasAdminPermission { get; set; }
    }
}
