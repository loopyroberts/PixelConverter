using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgToMatrix
{
    public partial class Form1 : Form
    {
        int IMGHEIGHT = 288;
        Bitmap bmp;
        Image image;
        public Form1()
        {
            InitializeComponent();
        }

        private void openBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog().Equals(DialogResult.OK))
            {
                image = Image.FromFile(fd.FileName);
                bmp = new Bitmap(image, image.Width, IMGHEIGHT);
                imageBox.Width = image.Width;
                imageBox.Image = image;
            }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Please select an image first", "Not yet!", MessageBoxButtons.OK);
            }
            else
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = nameBox.Text;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(sv.FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                    byte[] buf = new byte[IMGHEIGHT*3];
                    for (int i = 0; i < bmp.Width; i++)
                    {

                        //writer.Write("{");
                        for (int j = 0; j < IMGHEIGHT; j++)
                        {
                            //writer.Write("{");

                            buf[3 * j] = bmp.GetPixel(i, j).R;
                            //writer.Write(",");
                            buf[3 * j + 1] = bmp.GetPixel(i, j).G;
                            //writer.Write(",");
                            buf[3 * j + 2] = bmp.GetPixel(i, j).B;
                            //writer.Write("},");
                        }
                        fs.Write(buf, 0, IMGHEIGHT*3);
                    }
                    //writer.Write("};");
                    fs.Close();
                }
            }
        }

        private void heightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMGHEIGHT = Convert.ToInt32(heightBox.Text);
            imageBox.Height = IMGHEIGHT;
            panel1.Height = IMGHEIGHT + 24;
            Form1.ActiveForm.Height = IMGHEIGHT + 110;
            openBut.Location = new Point(openBut.Location.X, IMGHEIGHT + 42);
            nameBox.Location = new Point(nameBox.Location.X, IMGHEIGHT + 44);
            saveBut.Location = new Point(saveBut.Location.X, IMGHEIGHT + 42);
            heightBox.Location = new Point(heightBox.Location.X, IMGHEIGHT + 43);

        }
    }
}
