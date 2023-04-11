namespace SortingGame
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.PictureBox pictureBox3;
            this.hellotxt = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.About = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quicksort = new System.Windows.Forms.Button();
            this.incertsort = new System.Windows.Forms.Button();
            this.bubblesort = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hellotxt
            // 
            this.hellotxt.AllowDrop = true;
            this.hellotxt.AutoEllipsis = true;
            this.hellotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hellotxt.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellotxt.Location = new System.Drawing.Point(485, 96);
            this.hellotxt.Name = "hellotxt";
            this.hellotxt.Size = new System.Drawing.Size(744, 171);
            this.hellotxt.TabIndex = 0;
            this.hellotxt.Text = resources.GetString("hellotxt.Text");
            this.hellotxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hellotxt.UseCompatibleTextRendering = true;
            this.hellotxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.MistyRose;
            this.About.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(0, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(399, 58);
            this.About.TabIndex = 7;
            this.About.Text = "О программе";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(841, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // quicksort
            // 
            this.quicksort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quicksort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.quicksort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quicksort.Location = new System.Drawing.Point(0, 431);
            this.quicksort.Name = "quicksort";
            this.quicksort.Size = new System.Drawing.Size(399, 66);
            this.quicksort.TabIndex = 3;
            this.quicksort.Text = "Быстрая сортировка";
            this.quicksort.UseVisualStyleBackColor = false;
            this.quicksort.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // incertsort
            // 
            this.incertsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.incertsort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.incertsort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incertsort.Location = new System.Drawing.Point(0, 338);
            this.incertsort.Name = "incertsort";
            this.incertsort.Size = new System.Drawing.Size(399, 66);
            this.incertsort.TabIndex = 2;
            this.incertsort.Text = "Сортировка вставками";
            this.incertsort.UseVisualStyleBackColor = false;
            this.incertsort.Click += new System.EventHandler(this.button1_Click_1);
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
            this.bubblesort.Location = new System.Drawing.Point(0, 248);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(399, 66);
            this.bubblesort.TabIndex = 1;
            this.bubblesort.Text = "Пузырьковая сортировка";
            this.bubblesort.UseVisualStyleBackColor = false;
            this.bubblesort.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(399, 745);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1418, 744);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quicksort);
            this.Controls.Add(this.incertsort);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.hellotxt);
            this.Controls.Add(pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Обучающий тренажер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hellotxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bubblesort;
        private System.Windows.Forms.Button incertsort;
        private System.Windows.Forms.Button quicksort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button About;
    }
}

