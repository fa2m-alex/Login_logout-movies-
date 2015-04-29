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
    public partial class AddMoviePanel : Form
    {
        DBHelper db = new DBHelper();
        

        public AddMoviePanel()
        {
            InitializeComponent();

            UpdateCountries();
            UpdateGenres();
            UpdateStudios();
            UpdateStars();

            StartValuses();
        }

        private void StartValuses()
        {
            txtTitle.Text = "";
            txtYear.Text = "0";
            txtDuration.Text = "0";
            txtKinoPoisk.Text = "0";
            txtImdb.Text = "0";
            txtMetacritic.Text = "0";
            txtRotTom.Text = "0";
            txtAge.Text = "0";

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie mov = new Movie();

            mov.Title = txtTitle.Text;
            mov.Year = Convert.ToInt32(txtYear.Text);
            mov.Duration = Convert.ToInt32(txtDuration.Text);
            mov.KinoPoisk = Convert.ToDouble(txtKinoPoisk.Text);
            mov.Imdb = Convert.ToDouble(txtImdb.Text);
            mov.Metacritic = Convert.ToDouble(txtMetacritic.Text);
            mov.RottentTomatoes = Convert.ToDouble(txtRotTom.Text);
            mov.Age = Convert.ToInt32(txtAge.Text);

            db.AddMovie(mov);


            foreach (Country c in chBoxContrNames.CheckedItems)
            {
                db.AddMovieCountry(db.getMovies().Last(), c);
            }

            foreach (Genre g in chBoxGenres.CheckedItems)
            {
                db.AddMovieGenre(db.getMovies().Last(), g);
            }

            foreach (Studio s in chBoxStudios.CheckedItems)
            {
                db.AddMovieStudio(db.getMovies().Last(), s);
            }

            StartValuses();

           

            MessageBox.Show("Movie has been added");
            //StartValuses();

        }

        private void UpdateCountries()
        {
            for(int i = 0; i<db.getCountries().Count; i++)
            {
                chBoxContrNames.Items.Add(db.getCountries().ToArray()[i]);
            }
            
        }

        private void UpdateGenres()
        {
            for (int i = 0; i < db.getGenres().Count; i++)
            {
                chBoxGenres.Items.Add(db.getGenres().ToArray()[i]);
            }
        }

        private void UpdateStudios()
        {
            for (int i = 0; i < db.getStudios().Count; i++)
            {
                chBoxStudios.Items.Add(db.getStudios().ToArray()[i]);
            }
        }

        private void UpdateStars()
        {
            for (int i = 0; i < db.getStars().Count; i++)
            {
                /*chBoxDirectors.Items.Add(db.getStars().ToArray()[i]);
                chBoxActors.Items.Add(db.getStars().ToArray()[i]);
                chBoxProducers.Items.Add(db.getStars().ToArray()[i]);
                chBoxOperators.Items.Add(db.getStars().ToArray()[i]);
                chBoxEditors.Items.Add(db.getStars().ToArray()[i]);
                chBoxComposers.Items.Add(db.getStars().ToArray()[i]);*/
            }
        }


        private void chBoxContrNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
