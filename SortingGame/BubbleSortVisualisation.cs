using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingGame
{




    public partial class BubbleVisualisation : Form
    {

        int n = 20;
        int[] array = new int[20];
        PictureBox[] cols = new PictureBox[20];

        private static Random rng = new Random();
        public BubbleVisualisation()
        {
            InitializeComponent();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < n; i++)
            {
                cols[i] = new PictureBox();

                cols[i].Name = "pictureBox" + i;
                cols[i].Size = new Size(5, array[i] * 5);
                cols[i].Location = new Point(350 + i * 10, 170);
                cols[i].BackColor = Color.Black;

                this.Controls.Add(cols[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            System.Threading.Thread.Sleep(100);

           array = array.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0; i < n; i++)
            {
                cols[i].Height = 5 * array[i];
            }
            this.Update();

            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        cols[j].Height = array[j] * 5;
                        cols[j].BackColor = Color.Red;
                        cols[j + 1].BackColor = Color.Red;
                        cols[j + 1].Height = array[j + 1] * 5;

                        this.Update();
                        System.Threading.Thread.Sleep(50);

                        cols[j].BackColor = Color.Black;
                        cols[j + 1].BackColor = Color.Black;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                cols[i].BackColor = Color.Green;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void visualisationbtn_Click(object sender, EventArgs e)
        {
            var form = new Analyses();
            form.ShowDialog();
        }

        private void BubbleVisualisation_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
