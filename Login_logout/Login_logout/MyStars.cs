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
    public partial class MyStars : Form
    {
        DBHelper db = new DBHelper();
        User user;

        public MyStars(User newUser)
        {
            InitializeComponent();

            user = newUser;
            UpdateMyStars();
        }

        private void UpdateMyStars()
        {
            for (int i = 0; i < db.getStarsByUser(user).Count; i++)
            {
                listBox1.Items.Add(db.getStarsByUser(user).ToArray()[i]);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StarInfo si = new StarInfo(listBox1.SelectedItem as Star);
            si.Show();
        }
    }
}
