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
    public partial class AddGenrePanel : Form
    {
        private DBHelper db = new DBHelper();

        public AddGenrePanel()
        {
            InitializeComponent();

            UpdateGenres();
        }

        private void UpdateGenres()
        {
            cmbGenre.DataSource = db.getGenres();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Genre g = new Genre();

            g.GenreName = txtGenre.Text;
            db.AddGenre(g);

            MessageBox.Show("Genre has been added");

            UpdateGenres();

            txtGenre.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Genre g = new Genre();
            g = cmbGenre.SelectedItem as Genre;

            db.DeleteGenre(g);
            UpdateGenres();
        }


    }
}
