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

    public partial class AddStudioPanel : Form
    {
        private DBHelper db = new DBHelper();

        public AddStudioPanel()
        {
            InitializeComponent();

            UpdateStudios();
        }

        private void UpdateStudios()
        {
            cmbStudio.DataSource = db.getStudios();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Studio s = new Studio();

            s.StudioName = txtStudio.Text;
            db.AddStudio(s);

            MessageBox.Show("Studio has been added");

            UpdateStudios();

            txtStudio.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Studio s = new Studio();
            s = cmbStudio.SelectedItem as Studio;

            db.DeleteStudio(s);
            UpdateStudios();
        }


    }
}
