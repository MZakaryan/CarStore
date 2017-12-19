using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

        public bool LoginExists(string login)
        {
            XDocument doc = XDocument.Load(_dbPath);
            return doc.Root.Elements().Where(u => u.Element("Login").Value == login).Any();
        }

        public void Export(UserRegistrationInfo userRegistrationInfo)
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(_dbPath);

            XmlElement parentElement = xmlEmloyeeDoc.CreateElement("User");

            XmlElement userId = xmlEmloyeeDoc.CreateElement("UserId");
            userId.InnerText = userRegistrationInfo.UserId.ToString();
            XmlElement login = xmlEmloyeeDoc.CreateElement("Login");
            login.InnerText = userRegistrationInfo.Login;
            XmlElement password = xmlEmloyeeDoc.CreateElement("Password");
            password.InnerText = userRegistrationInfo.Password;
            XmlElement hasAdminPermission = xmlEmloyeeDoc.CreateElement("HasAdminPermission");
            hasAdminPermission.InnerText = "false";

            parentElement.AppendChild(userId);
            parentElement.AppendChild(login);
            parentElement.AppendChild(password);
            parentElement.AppendChild(hasAdminPermission);

            xmlEmloyeeDoc.DocumentElement.AppendChild(parentElement);
            xmlEmloyeeDoc.Save(_dbPath);
        }
    }
}
