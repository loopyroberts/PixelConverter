namespace ImgToMatrix
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.openBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heightBox = new System.Windows.Forms.ComboBox();
            this.gammaBox = new System.Windows.Forms.TextBox();
            this.gammaLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(3, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(515, 288);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(177, 332);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "image.pix";
            // 
            // openBut
            // 
            this.openBut.Location = new System.Drawing.Point(12, 330);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(75, 23);
            this.openBut.TabIndex = 2;
            this.openBut.Text = "Open Image";
            this.openBut.UseVisualStyleBackColor = true;
            this.openBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(382, 330);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 3;
            this.saveBut.Text = "Save File";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imageBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 312);
            this.panel1.TabIndex = 5;
            // 
            // heightBox
            // 
            this.heightBox.FormattingEnabled = true;
            this.heightBox.Items.AddRange(new object[] {
            "288",
            "60"});
            this.heightBox.Location = new System.Drawing.Point(463, 331);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(73, 21);
            this.heightBox.TabIndex = 6;
            this.heightBox.Text = "288";
            this.heightBox.SelectedIndexChanged += new System.EventHandler(this.heightBox_SelectedIndexChanged);
            // 
            // gammaBox
            // 
            this.gammaBox.Location = new System.Drawing.Point(142, 332);
            this.gammaBox.Name = "gammaBox";
            this.gammaBox.Size = new System.Drawing.Size(29, 20);
            this.gammaBox.TabIndex = 1;
            this.gammaBox.Text = "2.4";
            this.gammaBox.TextChanged += new System.EventHandler(this.gammaBox_TextChanged);
            // 
            // gammaLab
            // 
            this.gammaLab.AutoSize = true;
            this.gammaLab.Location = new System.Drawing.Point(93, 335);
            this.gammaLab.Name = "gammaLab";
            this.gammaLab.Size = new System.Drawing.Size(43, 13);
            this.gammaLab.TabIndex = 7;
            this.gammaLab.Text = "Gamma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 359);
            this.Controls.Add(this.gammaLab);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.gammaBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Pixel Stick formatter";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox heightBox;
        private System.Windows.Forms.TextBox gammaBox;
        private System.Windows.Forms.Label gammaLab;
    }
}

