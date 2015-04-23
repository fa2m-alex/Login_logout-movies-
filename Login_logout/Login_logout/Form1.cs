using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseHelper;
using Tables;

namespace Login_logout
{
    public partial class Form1 : Form
    {
        DBHelper db = new DBHelper();

        public Form1()
        {
            InitializeComponent();

            txtLogin.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < db.getUsers().Count; i++)
            {
                if (txtLogin.Text.Equals(db.getUsers().ToArray()[i].Login) && 
                    txtPassword.Text.Equals(db.getUsers().ToArray()[i].Password))
                {
                    if (/*txtLogin.Text.Equals("admin")*/  db.getUsers().ToArray()[i].Type.Equals("admin"))
                    {
                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                        this.Hide();

                        txtLogin.Text = "";
                        txtPassword.Text = "";
                    }
                    else if (db.getUsers().ToArray()[i].Equals("user"))
                    {
                        Main main = new Main(db.getUsers().ToArray()[i]);
                        main.Show();
                        this.Hide();

                        txtLogin.Text = "";
                        txtPassword.Text = "";

                        break;
                    }
                    
                    
                }
               /* else
                {
                    MessageBox.Show("");
                   // break;
                }*/
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPanel rp = new RegisterPanel();
            rp.Show();
        }
    }
}
