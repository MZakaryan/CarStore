﻿using CarStore.Helpers;
using CarStoreInfo;
using CarStoreRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    
    class RegistrationController
    {
        private UserAuthenticationRepository _userAuthenticationRepository;
        public RegistrationController()
        {
            _userAuthenticationRepository = new UserAuthenticationRepository();
        }


  
        public bool Registrate(UserRegistrationInfo userRegistrationInfo)
        {
            bool isValid = ValidationHelper.IsRegFieldsCompleted(userRegistrationInfo)
                && ValidationHelper.IsPasswordSame(userRegistrationInfo.Password, userRegistrationInfo.ConfirmPassword)
                && !_userAuthenticationRepository.LoginExists(userRegistrationInfo.Login);
            if (isValid)
            {
                userRegistrationInfo.HasAdminPermission = false;
                if (!_userAuthenticationRepository.Export(userRegistrationInfo))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
