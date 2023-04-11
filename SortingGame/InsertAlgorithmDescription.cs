using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingGame
{
    public partial class InsertAlgorithmDescription : Form
    {


        public InsertAlgorithmDescription()
        {
            InitializeComponent();
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visualisationbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new InsertVisulisation();
            form.ShowDialog();
        }

        private void InsertAlgorithmDescription_Load(object sender, EventArgs e)
        {

        }
    }
}
