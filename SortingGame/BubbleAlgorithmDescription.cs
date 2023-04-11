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
    public partial class BubbleAlgorithmDescription : Form
    {
        public BubbleAlgorithmDescription()
        {
            InitializeComponent();
        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

        private void AlgorithmDescription_Load(object sender, EventArgs e)
        {
           
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new BubbleVisualisation();
            form.ShowDialog();
        }
    }
}
