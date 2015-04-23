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
    public partial class UsersList : Form
    {
        DBHelper db = new DBHelper();

        public UsersList()
        {
            InitializeComponent();

            UpdateUsers();
        }

        private void UpdateUsers()
        {
            comboBox1.DataSource = db.getUsers();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User u = new User();
            u = comboBox1.SelectedItem as User;

            db.DeleteUser(u);

            MessageBox.Show("User has been deleted");

            UpdateUsers();
        }
    }
}
