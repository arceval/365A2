using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public class Background
    {
        public static void setBackground(PictureBox pix, OpenFileDialog bIn)
        {
            int frameX, frameY;
            if(bIn.ShowDialog() == DialogResult.OK)
            {
                // Get image form file.
                pix.Image = Image.FromFile(bIn.FileName);
                // Update form size for image.
                frameX = (pix.Width + 36);
                frameY = (pix.Height + 120);
                Form.ActiveForm.Size = new System.Drawing.Size(frameX, frameY);
            }

        }
    }
}
