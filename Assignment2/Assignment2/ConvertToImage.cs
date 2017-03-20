using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    class ConvertToImage
    {
        public static Bitmap YUVToRGBImage(List<List<int>> Y, List<List<int>> U, List<List<int>> V)
        {
            // Takes in 2d array
            int A, R, G, B;
            A = 255;
            Color pix;
            Bitmap builtBmp = new Bitmap(Y[0].Count,Y.Count);

            // http://www.pcmag.com/encyclopedia/term/55166/yuv-rgb-conversion-formulas
            // Conversion formulae
            //R = Y + 1.140V
            //G = Y - 0.395U - 0.581V
            //B = Y + 2.032U
            for (int y = 0; y < Y.Count; y++)
            {
                for(int x = 0; x < Y[0].Count; x++)
                {
                    R = (byte)(Y[x][y] + (1.14 * U[(int)(Math.Floor((decimal)x / 2))][(int)(Math.Floor((decimal)y / 2))]));
                    G = (byte)(Y[x][y] - (0.395 * U[(int)(Math.Floor((decimal)x / 2))][(int)(Math.Floor((decimal)y / 2))]) - (0.581 * V[(int)(Math.Floor((decimal)x / 2))][(int)(Math.Floor((decimal)y / 2))]));
                    B = (byte)(Y[x][y] + (2.032 * U[(int)(Math.Floor((decimal)x / 2))][(int)(Math.Floor((decimal)y / 2))]));

                    pix = Color.FromArgb(A,R,G,B);
                    builtBmp.SetPixel(x, y, pix);
                }
            }

            return builtBmp;

        }

    }
}
