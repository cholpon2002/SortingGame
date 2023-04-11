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
    public partial class InsertVisulisation : Form
    {

        int n = 20;
        int[] array = new int[20];
        PictureBox[] cols = new PictureBox[20];

        private static Random rng = new Random();
        public InsertVisulisation()
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

  

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bubblesort_Click(object sender, EventArgs e)
        {
            var form = new BubbleVisualisation();
            form.ShowDialog();
        }

        private void quicksort_Click(object sender, EventArgs e)
        {

        }

        private void visualisationbtn_Click(object sender, EventArgs e)
        {
            var form = new Analyses();
            form.ShowDialog();
        }

        private void InsertVisulisation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(100);

            array = array.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0; i < n; i++)
            {
                cols[i].Height = 5 * array[i];
            }
            this.Update();



            for (int i = 0; i < n - 1; i++)
            {
                int mini = i;
                for (int j = i; j < n; j++)
                {
                    
                    if (array[mini] > array[j])
                    {
                        mini = j;
                    }
                }

                int temp = array[mini];
                array[mini] = array[i];
                array[i] = temp;

                cols[i].Height = array[i] * 5;
                cols[i].BackColor = Color.Red;
                cols[mini].BackColor = Color.Red;
                cols[mini].Height = array[mini] * 5;

                this.Update();
                System.Threading.Thread.Sleep(50);

                cols[i].BackColor = Color.Black;
                cols[mini].BackColor = Color.Black;

            }

            for (int i = 0; i < n; i++)
            {
                cols[i].BackColor = Color.Green;
            }
        }
    }
    }

