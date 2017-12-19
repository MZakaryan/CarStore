using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarStoreRepository
{
    public class UserAuthenticationRepository
    {
        private string _dbPath;

        public UserAuthenticationRepository()
        {
            _dbPath = AppDomain.CurrentDomain.BaseDirectory + @"XML\Users.xml";
        }

        public bool IsUserDataValid(UserLoginInfo userLoginInfo)
        {
            XDocument doc = XDocument.Load(_dbPath);
            return doc.Root.Elements().Select(x => new UserLoginInfo()
            {
                Login = x.Element("Login").Value,
                Password = x.Element("Password").Value
            }).Where(u => u.Login == userLoginInfo.Login && u.Password 
               == userLoginInfo.Password).Any();
        }

        public UserInfo Import(UserLoginInfo userLoginInfo)
        {
            XDocument doc = XDocument.Load(_dbPath);
            List<UserInfo> users = doc.Root.Elements().Select(x =>
            new UserInfo()
            {
                Login = x.Element("Login").Value,
                Password = x.Element("Password").Value,
                UserId = Guid.Parse(x.Element("UserId").Value),
                HasAdminPermission = Convert.ToBoolean(x.Element("HasAdminPermission").Value)
            }).ToList();

            return users.Where(u => u.Login == userLoginInfo.Login && u.Password 
                   == userLoginInfo.Password).FirstOrDefault();
        }


    }
}
