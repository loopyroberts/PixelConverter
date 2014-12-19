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
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(3, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(509, 60);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(93, 103);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(362, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "image.pix";
            // 
            // openBut
            // 
            this.openBut.Location = new System.Drawing.Point(12, 102);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(75, 23);
            this.openBut.TabIndex = 2;
            this.openBut.Text = "Open Image";
            this.openBut.UseVisualStyleBackColor = true;
            this.openBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(461, 102);
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
            this.panel1.Size = new System.Drawing.Size(524, 84);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 132);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.openBut);
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
    }
}

