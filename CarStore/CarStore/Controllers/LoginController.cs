using CarStore.Helpers;
using CarStoreInfo;
using CarStoreRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    class LoginController
    {
        private UserAuthenticationRepository _userAuthenticationRepository;

        public LoginController()
        {
            _userAuthenticationRepository = new UserAuthenticationRepository();
        }

        public bool IsValidLogin(UserLoginInfo userLoginInfo)
        {
            return ValidationHelper.IsLoginFieldsCompleted(userLoginInfo)
                   && _userAuthenticationRepository.IsUserDataValid(userLoginInfo);
        }

        public UserController GetUserRole(UserLoginInfo userLoginInfo)
        {
            UserInfo userInfo = _userAuthenticationRepository.Import(userLoginInfo);
            if (userInfo.HasAdminPermission)
            {
                return new AdminController(userInfo);
            }
            else
            {
                return new ClientController(userInfo);
            }
        }
    }
}
