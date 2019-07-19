using ExtraClassLibrary;
using ExtraClassLibrary.DataAccess;
using ExtraClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraClassUI
{
    public partial class CreateUserForm : Form
    {
        private List<RoleModel> roles = new List<RoleModel>();
        public CreateUserForm()
        {
            InitializeComponent();

        }

        private bool ValidateForm()
        {
            bool output = true;
            if(emailTb.Text.Length == 0 || userNameTb.Text.Length == 0 || passwordTb.Text.Length == 0)
            {
                output = false;
            }

            if (!IsValidEmail(emailTb.Text))
            {
                output = false;
            }

            return output;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LoadListRoles()
        {
            roles = GlobalConfig.Connection.GetAllRoles();
        }

        private void WirreUpList()
        {
            
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UserModel model = new UserModel(
                    userNameTb.Text,
                    passwordTb.Text,
                    emailTb.Text,
                    addressTb.Text);

                GlobalConfig.Connection.CreateUser(model);
       
            }
            else
            {
                MessageBox.Show("Invalid some text in Form. Please check it carefully", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
