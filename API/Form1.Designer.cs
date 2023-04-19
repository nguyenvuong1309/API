namespace API
{
    partial class Form1
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
            this.find = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.movieName = new System.Windows.Forms.Label();
            this.movieLanguage = new System.Windows.Forms.Label();
            this.movieRelease = new System.Windows.Forms.Label();
            this.movieVoteAverage = new System.Windows.Forms.Label();
            this.movieVoteCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(41, 32);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(125, 53);
            this.find.TabIndex = 0;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(189, 47);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(794, 22);
            this.textBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "The Super Mario Bros. Movie",
            "Shazam! Fury of the Gods        ",
            "Avatar: The Way of Water        ",
            "Creed III",
            "65",
            "Murder Mystery 2",
            "Puss in Boots: The Last Wish    ",
            "The Pope\'s Exorcist",
            "John Wick: Chapter 4",
            "Cocaine Bear",
            "Momias",
            "길복순",
            "Winnie the Pooh: Blood and Honey",
            "Attack on Titan",
            "Infelices para Siempre",
            "Chupa",
            "Supercell",
            "The Park",
            "The Mummy Resurrection",
            "La Exorcista"});
            this.comboBox1.Location = new System.Drawing.Point(189, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // movieName
            // 
            this.movieName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieName.Location = new System.Drawing.Point(559, 167);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(267, 23);
            this.movieName.TabIndex = 5;
            this.movieName.Text = "name";
            // 
            // movieLanguage
            // 
            this.movieLanguage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieLanguage.Location = new System.Drawing.Point(559, 230);
            this.movieLanguage.Name = "movieLanguage";
            this.movieLanguage.Size = new System.Drawing.Size(267, 23);
            this.movieLanguage.TabIndex = 6;
            this.movieLanguage.Text = "language";
            // 
            // movieRelease
            // 
            this.movieRelease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieRelease.Location = new System.Drawing.Point(559, 287);
            this.movieRelease.Name = "movieRelease";
            this.movieRelease.Size = new System.Drawing.Size(267, 23);
            this.movieRelease.TabIndex = 7;
            this.movieRelease.Text = "ReleaseDate";
            // 
            // movieVoteAverage
            // 
            this.movieVoteAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieVoteAverage.Location = new System.Drawing.Point(559, 350);
            this.movieVoteAverage.Name = "movieVoteAverage";
            this.movieVoteAverage.Size = new System.Drawing.Size(267, 23);
            this.movieVoteAverage.TabIndex = 8;
            this.movieVoteAverage.Text = "Vote Average";
            // 
            // movieVoteCount
            // 
            this.movieVoteCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movieVoteCount.Location = new System.Drawing.Point(559, 410);
            this.movieVoteCount.Name = "movieVoteCount";
            this.movieVoteCount.Size = new System.Drawing.Size(267, 23);
            this.movieVoteCount.TabIndex = 9;
            this.movieVoteCount.Text = "VoteCount";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(408, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(408, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Language";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(408, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(408, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vote Average";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(408, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vote Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Choose name movie";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 167);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(351, 411);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 655);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieVoteCount);
            this.Controls.Add(this.movieVoteAverage);
            this.Controls.Add(this.movieRelease);
            this.Controls.Add(this.movieLanguage);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.find);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label movieLanguage;
        private System.Windows.Forms.Label movieRelease;
        private System.Windows.Forms.Label movieVoteAverage;
        private System.Windows.Forms.Label movieVoteCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView;
    }
}

