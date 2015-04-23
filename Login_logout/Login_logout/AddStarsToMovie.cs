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

    public partial class AddStarsToMovie : Form
    {
        DBHelper db = new DBHelper();

        public AddStarsToMovie()
        {
            InitializeComponent();

            UpdateStars();
            UpdateMovies();
        }

        private void UpdateStars()
        {
            for (int i = 0; i < db.getStars().Count; i++)
            {
                checkedListBox1.Items.Add(db.getStars().ToArray()[i]);
                
            }
        }

        private void UpdateMovies()
        {
            comboBox1.DataSource = db.getMovies();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = comboBox1.SelectedItem as Movie;

            if (radioDirector.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "director");
                }

                MessageBox.Show("Directors have been added to movie: " + movie.Title);
            }
            else if(radioActor.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "actor");
                }

                MessageBox.Show("Actors have been added to movie: " + movie.Title);
            }
            else if (radioProducer.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "producer");
                }

                MessageBox.Show("Producers have been added to movie: " + movie.Title);
            }
            else if (radioOper.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "operator");
                }

                MessageBox.Show("Operators have been added to movie: " + movie.Title);
            }
            else if (radioEditor.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "editor");
                }

                MessageBox.Show("Editors have been added to movie: " + movie.Title);
            }
            else if (radioComp.Checked)
            {
                foreach (Star s in checkedListBox1.CheckedItems)
                {
                    db.AddParticularMovie(movie, s, "composer");
                }

                MessageBox.Show("Composers have been added to movie: " + movie.Title);
            }
        }
    }
}
