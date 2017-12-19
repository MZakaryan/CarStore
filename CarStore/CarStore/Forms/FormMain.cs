using CarStore.Controllers;
using CarStore.Forms;
using CarStore.Helpers;
using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStore
{
    public partial class FormMain : Form
    {
        private LoginController _loginController;
        public FormMain()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginInfo userLoginInfo =
                Maper.MapingLoginInfo(txtLogin.Text, txtPass.Text);
            if (_loginController.IsValidLogin(userLoginInfo))
            {
                UserController userController 
                    = _loginController.GetUserRole(userLoginInfo);
                userController.ShowUserInterface();
            }
            else
            {
                MessageBox.Show("Invalid Login or Password!!!");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormRegistration reg = new FormRegistration();
            reg.ShowDialog();
            if (reg.DialogResult == DialogResult.OK)
            {
                Visible = true;
            }
        }
    }
}
