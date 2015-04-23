using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables;
using DatabaseHelper;

namespace Login_logout
{
    public partial class RegisterPanel : Form
    {
        DBHelper db = new DBHelper();

        public RegisterPanel()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.Login = txtLogin.Text;
            u.Password = txtPass.Text;

            if (radioUser.Checked)
            {
                u.Type = "user";
            }
            else
            {
                u.Type = "admin";
            }

            db.AddUser(u);

            MessageBox.Show("You have been registrated as " + u.Type);

            txtLogin.Text = "";
            txtPass.Text = "";
        }
    }
}
