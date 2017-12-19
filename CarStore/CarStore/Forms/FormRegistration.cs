using CarStoreInfo;
using System;
using CarStore.Helpers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarStore.Controllers;

namespace CarStore.Forms
{
    public partial class FormRegistration : Form
    {
        private RegistrationController _registrationController;
        public FormRegistration()
        {
            InitializeComponent();
            _registrationController = new RegistrationController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegistrationInfo userRegistrationInfo 
                = Maper.MapingRegistrationInfo(txtLogin.Text, txtPass.Text, txtConfPass.Text);
            if (_registrationController.Registrate(userRegistrationInfo))
            {
                MessageBox.Show("Successfully completed.");
                Close();
            }
            else
            {
                MessageBox.Show("Invalid registration!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
