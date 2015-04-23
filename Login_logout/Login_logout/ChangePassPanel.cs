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
    public partial class ChangePassPanel : Form
    {
        DBHelper db = new DBHelper();
        User user;

        public ChangePassPanel(User newUser)
        {
            InitializeComponent();

            user = newUser;
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            db.ChangePassword(user, txtNewPass.Text);

            MessageBox.Show("Password has been changed");
        }
    }
}
