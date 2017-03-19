using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public class ConvertImage
    {
        public static Image[] toYUV(Image inImage)
        {
            Image[] YUV = new Image[3];

            int Y, U, V, a = 255;
            
            Bitmap inBmp = new Bitmap(inImage);
            Color inPix, outPix;
            Bitmap outY = new Bitmap(inImage.Width,inImage.Height);

            for(int y = 0; y < inImage.Height; y++)
            {
                for (int x = 0; x < inImage.Width; x++)
                {
                    inPix = inBmp.GetPixel(x, y);
                    Y = ((66 * inPix.R + 129 * inPix.G + 25 * inPix.B + 128) >> 8) + 16;
                    outPix = 
                    outY.SetPixel(x, y, Y);

                } 
            }
            // Sample Y on each pixel
            Y = ((66 * R + 129 * G + 25 * B + 128) >> 8) + 16;
            U = ((-38 * R - 74 * G + 112 * B + 128) >> 8) + 128;
            V = ((112 * R - 94 * G - 18 * B + 128) >> 8) + 128; 

            // Sample U and V as the average between the first and second line, the odd pixels on these lines. Each line is sampled once.

            return YUV;

        }
    }
}
