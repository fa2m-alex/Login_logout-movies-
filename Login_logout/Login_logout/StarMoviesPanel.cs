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
    public partial class StarMoviesPanel : Form
    {
        private DBHelper db = new DBHelper();

        private Star star;

        public StarMoviesPanel(Star newStar)
        {
            InitializeComponent();

            star = newStar;

            UpdateMovies();
        }

        private void UpdateMovies()
        {
            for (int i = 0; i < db.getStarMovies(star).Count; i++)
            {
                listBox1.Items.Add(db.getStarMovies(star).ToArray()[i]);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StarMovieInfo smi = new StarMovieInfo(listBox1.SelectedItem as Movie, star);
            smi.Show();
        }

        


    }
}
