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
    public partial class UpdateMoviePanel : Form
    {
        private Movie movie;
        DBHelper db = new DBHelper();

        public UpdateMoviePanel(Movie newMovie)
        {
            InitializeComponent();

            movie = newMovie;

            UpdateCountries();
            UpdateGenres();
            UpdateStudios();
            UpdateStars();

            FillFields();
        }

        private void UpdateCountries()
        {
            for (int i = 0; i < db.getCountries().Count; i++)
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

        private void FillFields()
        {
            txtTitle.Text = movie.Title;
            txtYear.Text = "" + movie.Year;
            txtDuration.Text = "" + movie.Duration;
            txtAge.Text = "" + movie.Age;
            txtKinoPoisk.Text = "" + movie.KinoPoisk;
            txtImdb.Text = "" + movie.Imdb;
            txtMetacritic.Text = "" + movie.Metacritic;
            txtRotTom.Text = "" + movie.RottentTomatoes;

            
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();

            newMovie.Title = txtTitle.Text;
            newMovie.Year = Convert.ToInt32(txtYear.Text);
            newMovie.Duration = Convert.ToInt32(txtDuration.Text);
            newMovie.KinoPoisk = Convert.ToDouble(txtKinoPoisk.Text);
            newMovie.Imdb = Convert.ToDouble(txtImdb.Text);
            newMovie.Metacritic = Convert.ToDouble(txtMetacritic.Text);
            newMovie.RottentTomatoes = Convert.ToDouble(txtRotTom.Text);
            newMovie.Age = Convert.ToInt32(txtAge.Text);

            db.UpdateMovie(movie, newMovie);

            db.DeleteMovieCountry(movie);
            foreach (Country c in chBoxContrNames.CheckedItems)
            {
                db.AddMovieCountry(movie, c);
            }

            db.DeleteMovieGenre(movie);
            foreach (Genre g in chBoxGenres.CheckedItems)
            {
                db.AddMovieGenre(movie, g);
            }

            db.DeleteMovieStudio(movie);
            foreach (Studio s in chBoxStudios.CheckedItems)
            {
                db.AddMovieStudio(movie, s);
            }

            /*foreach (Star s in chBoxDirectors.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "director");
            }

            foreach (Star s in chBoxActors.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "actor");
            }

            foreach (Star s in chBoxProducers.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "producer");
            }

            foreach (Star s in chBoxOperators.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "operator");
            }

            foreach (Star s in chBoxEditors.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "editor");
            }

            foreach (Star s in chBoxComposers.CheckedItems)
            {
                db.AddParticularMovie(movie, s, "composer");
            }*/

            MessageBox.Show("Movie has been updated");
        }
    }
}
