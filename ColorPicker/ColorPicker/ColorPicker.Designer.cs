namespace ColorPicker
{
    partial class ColorPicker
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.tbxPickAColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(125, 75);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(55, 40);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.Location = new System.Drawing.Point(545, 150);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(55, 40);
            this.btnPurple.TabIndex = 1;
            this.btnPurple.Text = "Purple";
            this.btnPurple.UseVisualStyleBackColor = true;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.Location = new System.Drawing.Point(405, 75);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(55, 40);
            this.btnOrange.TabIndex = 2;
            this.btnOrange.Text = "Orange";
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(405, 150);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(55, 40);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(265, 150);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(55, 40);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(265, 75);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(55, 40);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(125, 150);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(55, 40);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.Text = "Back";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(545, 75);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(55, 40);
            this.btnWhite.TabIndex = 7;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // tbxPickAColor
            // 
            this.tbxPickAColor.Location = new System.Drawing.Point(320, 288);
            this.tbxPickAColor.Name = "tbxPickAColor";
            this.tbxPickAColor.Size = new System.Drawing.Size(100, 20);
            this.tbxPickAColor.TabIndex = 8;
            this.tbxPickAColor.Text = "Pick a color!";
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.tbxPickAColor);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnRed);
            this.Name = "ColorPicker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.TextBox tbxPickAColor;
    }
}

