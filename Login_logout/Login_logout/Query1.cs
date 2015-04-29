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
    public partial class Query1 : Form
    {
        public Query1()
        {
            DBHelper db = new DBHelper();

            InitializeComponent();

            this.Text = "Users";

            for (int i = 0; i < db.Query1().Count; i++)
            {
                listBox1.Items.Add(db.Query1().ToArray()[i]);

            }
        }

 
    }
}
