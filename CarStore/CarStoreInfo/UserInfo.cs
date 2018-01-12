using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInfo
{
    public class UserLoginInfo : EntityBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserInfo : UserLoginInfo
    {
        public bool HasAdminPermission { get; set; }
    }

    public class UserRegistrationInfo : UserInfo
    {
        public string ConfirmPassword { get; set; }
    }
}
