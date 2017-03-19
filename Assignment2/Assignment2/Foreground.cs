using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment2
{
    class Foreground
    {
        public static void setForeground(PictureBox pix, OpenFileDialog fIn)
        {
            Image sprite;
            Bitmap sBmp, curr;
            int pixX, pixY, sX, sY, startX, startY, endX, endY;
            if(fIn.ShowDialog() == DialogResult.OK)
            {
                sprite = Image.FromFile(fIn.FileName);
                sX = sprite.Width;
                sY = sprite.Height;
                pixX = pix.Width;
                pixY = pix.Height;
                
                startX = (pixX / 2) - (sX / 2);
                endX = startX + sX;
                startY = (pixY / 2) - (sY / 2);
                endY = startY + sY;

                sBmp = new Bitmap(sprite);
                curr = new Bitmap(pix.Image);
                Color clrt = sBmp.GetPixel(0,0);
                
                Console.WriteLine(clrt.A + " " + clrt.R + " " + clrt.G + " " + clrt.B);
                for (int i = 0; i < sX; i++)
                {
                    for(int j = 0; j < sY; j++)
                    {
                        // get pixel color
                        Color clr = sBmp.GetPixel(i, j); // Get the color of pixel at position 5,5
                        int alpha = clr.A;
                        int red = clr.R;
                        int green = clr.G;
                        int blue = clr.B;
                        

                        // if pixel is black or alpha, ignore
                        if ((red == 16 && green == 0 && blue == 4) || alpha == 0)
                        {
                            // The sprite provided doesn't have a proper alpha channel for the transparency.
                            // This should be alpha of 0, instead it is using a "black" of r = 16 g = 0 b = 4
                            // to represent alpha for some reason. The program will support an actual sprite
                            // or this test image. 
                        }else
                        {
                            // draw the pixel otherwise.
                            curr.SetPixel(startX + i, startY + j, clr);
                        }
                        
                    }
                }
                // set the image
                pix.Image = curr;

            }
        }
    }
}
