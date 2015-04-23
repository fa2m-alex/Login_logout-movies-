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
    public partial class MyMovies : Form
    {
        DBHelper db = new DBHelper();
        User user;

        public MyMovies(User newUser)
        {
            InitializeComponent();

            user = newUser;
            UpdateMyMovies();
        }

        private void UpdateMyMovies()
        {
            for (int i = 0; i < db.getMoviesByUser(user).Count; i++)
            {
                //chBoxContrNames.Items.Add(db.getCountries().ToArray()[i]);
                listBox1.Items.Add(db.getMoviesByUser(user).ToArray()[i]);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyMovieInfo mmi = new MyMovieInfo(listBox1.SelectedItem as Movie, user);
            mmi.Show();
        }

    }
}
