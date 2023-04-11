namespace SortingGame
{
    partial class InsertVisulisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertVisulisation));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Button();
            this.visualisationbtn = new System.Windows.Forms.Button();
            this.bubblesort = new System.Windows.Forms.Button();
            this.quicksort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(-2, -1);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(355, 780);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(859, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Время выполнения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Алгоритм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Перемешиваем...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 35);
            this.label1.TabIndex = 42;
            this.label1.Text = "Опробовать алгоритм самому";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.MistyRose;
            this.About.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(-2, -1);
            this.About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(355, 46);
            this.About.TabIndex = 41;
            this.About.Text = "О программе";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = false;
            // 
            // visualisationbtn
            // 
            this.visualisationbtn.BackColor = System.Drawing.Color.MistyRose;
            this.visualisationbtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualisationbtn.Location = new System.Drawing.Point(646, 505);
            this.visualisationbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visualisationbtn.Name = "visualisationbtn";
            this.visualisationbtn.Size = new System.Drawing.Size(355, 46);
            this.visualisationbtn.TabIndex = 49;
            this.visualisationbtn.Text = "сравнительный анализ ";
            this.visualisationbtn.UseVisualStyleBackColor = false;
            this.visualisationbtn.Click += new System.EventHandler(this.visualisationbtn_Click);
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
            this.bubblesort.Location = new System.Drawing.Point(-2, 251);
            this.bubblesort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(355, 53);
            this.bubblesort.TabIndex = 51;
            this.bubblesort.Text = "Пузырьковая сортировка";
            this.bubblesort.UseVisualStyleBackColor = false;
            this.bubblesort.Click += new System.EventHandler(this.bubblesort_Click);
            // 
            // quicksort
            // 
            this.quicksort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quicksort.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.quicksort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quicksort.Location = new System.Drawing.Point(-2, 333);
            this.quicksort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quicksort.Name = "quicksort";
            this.quicksort.Size = new System.Drawing.Size(355, 53);
            this.quicksort.TabIndex = 52;
            this.quicksort.Text = "Быстрая сортировка";
            this.quicksort.UseVisualStyleBackColor = false;
            this.quicksort.Click += new System.EventHandler(this.quicksort_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::SortingGame.Properties.Resources.Group_13866;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(-2, 422);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 53);
            this.button2.TabIndex = 81;
            this.button2.Text = "Сортировка вставками";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(413, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 82;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.ForestGreen;
            this.label16.Location = new System.Drawing.Point(940, 437);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 83;
            this.label16.Text = " O(n^2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Сортировка вставками";
            // 
            // InsertVisulisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1260, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.quicksort);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.visualisationbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.About);
            this.Controls.Add(pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertVisulisation";
            this.Text = "InsertVisulisation";
            this.Load += new System.EventHandler(this.InsertVisulisation_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button visualisationbtn;
        private System.Windows.Forms.Button bubblesort;
        private System.Windows.Forms.Button quicksort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
    }
}