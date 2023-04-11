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
    public partial class QuickVisualisation : Form
    {

        int n = 20;
        int[] array = new int[20];
        PictureBox[] cols = new PictureBox[20];

        private static Random rng = new Random();
        public QuickVisualisation()
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

        private void incertsort_Click(object sender, EventArgs e)
        {
            var form = new QuickSortAlgorithmDescription();
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

        private void bubblesort_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QuickVisualisation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             System.Threading.Thread.Sleep(100);

           array = array.OrderBy(x => rng.Next()).ToArray();

            for (int i = 0; i < n; i++)
            {
                cols[i].Height = 5 * array[i];
            }
            this.Update();

            quickSort(array, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                cols[i].BackColor = Color.Green;
            }
        }

       void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

            cols[i].Height = arr[i] * 5;
            cols[i].BackColor = Color.Red;
            cols[j].BackColor = Color.Red;
            cols[j].Height = arr[j] * 5;

            this.Update();
            System.Threading.Thread.Sleep(50);

            cols[i].BackColor = Color.Black;
            cols[j].BackColor = Color.Black;
        }
 
    /* This function takes last element as pivot, places
         the pivot element at its correct position in sorted
         array, and places all smaller (smaller than pivot)
         to left of pivot and all greater elements to right
         of pivot */
    int partition(int[] arr, int low, int high)
    {
 
        // pivot
        int pivot = arr[high];
 
        // Index of smaller element and
        // indicates the right position
        // of pivot found so far
        int i = (low - 1);
 
        for (int j = low; j <= high - 1; j++) {
 
            // If current element is smaller
            // than the pivot
            if (arr[j] < pivot) {
 
                // Increment index of
                // smaller element
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return (i + 1);
    }
 
    /* The main function that implements QuickSort
                arr[] --> Array to be sorted,
                low --> Starting index,
                high --> Ending index
       */
    void quickSort(int[] arr, int low, int high)
    {
        if (low < high) {
 
            // pi is partitioning index, arr[p]
            // is now at right place
            int pi = partition(arr, low, high);
 
            // Separately sort elements before
            // partition and after partition
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
