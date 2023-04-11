﻿namespace SortingGame
{
    partial class BubbleAlgorithmDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BubbleAlgorithmDescription));
            this.H1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visualisationbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.quicksort = new System.Windows.Forms.Button();
            this.incertsort = new System.Windows.Forms.Button();
            this.bubblesort = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(-1, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(355, 780);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.Location = new System.Drawing.Point(578, 30);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(351, 35);
            this.H1.TabIndex = 8;
            this.H1.Text = "Пузырьковая сортировка";
            this.H1.Click += new System.EventHandler(this.H1_Click);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(401, 81);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(820, 95);
            this.Description.TabIndex = 9;
            this.Description.Text = resources.GetString("Description.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сложность алгоритма: O(n^2)";
            // 
            // visualisationbtn
            // 
            this.visualisationbtn.BackColor = System.Drawing.Color.MistyRose;
            this.visualisationbtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualisationbtn.Location = new System.Drawing.Point(594, 510);
            this.visualisationbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visualisationbtn.Name = "visualisationbtn";
            this.visualisationbtn.Size = new System.Drawing.Size(355, 46);
            this.visualisationbtn.TabIndex = 12;
            this.visualisationbtn.Text = "Показать визуализацию алгоритма";
            this.visualisationbtn.UseVisualStyleBackColor = false;
            this.visualisationbtn.Click += new System.EventHandler(this.About_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 305);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.MistyRose;
            this.About.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(-1, 0);
            this.About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(355, 46);
            this.About.TabIndex = 13;
            this.About.Text = "О программе";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = false;
            // 
            // quicksort
            // 
            this.quicksort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quicksort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.quicksort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quicksort.Location = new System.Drawing.Point(-1, 450);
            this.quicksort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quicksort.Name = "quicksort";
            this.quicksort.Size = new System.Drawing.Size(355, 53);
            this.quicksort.TabIndex = 76;
            this.quicksort.Text = "Быстрая сортировка";
            this.quicksort.UseVisualStyleBackColor = false;
            // 
            // incertsort
            // 
            this.incertsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.incertsort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.incertsort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incertsort.Location = new System.Drawing.Point(-1, 375);
            this.incertsort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incertsort.Name = "incertsort";
            this.incertsort.Size = new System.Drawing.Size(355, 53);
            this.incertsort.TabIndex = 75;
            this.incertsort.Text = "Сортировка вставками";
            this.incertsort.UseVisualStyleBackColor = false;
            // 
            // bubblesort
            // 
            this.bubblesort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bubblesort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.bubblesort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bubblesort.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bubblesort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bubblesort.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblesort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bubblesort.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bubblesort.Location = new System.Drawing.Point(-1, 303);
            this.bubblesort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(355, 53);
            this.bubblesort.TabIndex = 74;
            this.bubblesort.Text = "Пузырьковая сортировка";
            this.bubblesort.UseVisualStyleBackColor = false;
            // 
            // BubbleAlgorithmDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1260, 595);
            this.Controls.Add(this.quicksort);
            this.Controls.Add(this.incertsort);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.About);
            this.Controls.Add(this.visualisationbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.H1);
            this.Controls.Add(pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BubbleAlgorithmDescription";
            this.Text = "AlgorithmDescription";
            this.Load += new System.EventHandler(this.AlgorithmDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visualisationbtn;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button quicksort;
        private System.Windows.Forms.Button incertsort;
        private System.Windows.Forms.Button bubblesort;
    }
}