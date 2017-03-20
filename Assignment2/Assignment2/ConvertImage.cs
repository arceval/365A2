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
        private static YUV RGB2YUV(RGB rgb)
        {
            var y = ((66 * rgb.R + 129 * rgb.G + 25 * rgb.B + 128) >> 8) + 16;
            var u = ((-38 * rgb.R - 74 * rgb.G + 112 * rgb.B + 128) >> 8) + 128;
            var v = ((112 * rgb.R - 94 * rgb.G - 18 * rgb.B + 128) >> 8) + 128;
            return new YUV(y, u, v);
        }

        private static RGB toRGB(Color c)
        {
            var r = c.R;
            var g = c.G;
            var b = c.B;
            return new RGB(r, g, b);
        }

        public static void toYUV444(Image inImage)
        {
            if (inImage == null) return;
            Bitmap bmp = new Bitmap(inImage);
            
            for (int c=0; c<bmp.Width; c++)
            {
                var y = new List<float>();
                var u = new List<float>();
                var v = new List<float>();
                for (int r=0; r<bmp.Height; r++)
                {
                    var color = toRGB(bmp.GetPixel(c, r));
                    y.Add(RGB2YUV(color).Y);
                    u.Add(RGB2YUV(color).U);
                    v.Add(RGB2YUV(color).V);
                }

                Form1.YList.Add(y);
                Form1.UList.Add(u);
                Form1.VList.Add(v);
            }
        }

        public static void toYUV420()
        {
            var tempUList = new List<List<float>>(Form1.UList.Count / 2);
            var tempVList = new List<List<float>>(Form1.VList.Count / 2);

            for (int i=0; i<Form1.UList.Count/2; i++)
            {
                var u = new List<float>();
                var v = new List<float>();
                for (int j=0; j<Form1.UList.Count/2; j++)
                {
                    u.Add(0);
                    v.Add(0);
                }
                tempUList.Add(u);
                tempVList.Add(v);
            }

            for (int i=0, i2=0; i<tempUList.Count; i+=2, i2++)
            {
                if (i2 >= tempUList.Count) continue;
                var crrow = tempUList[i2];
                var cbrow = tempVList[i2];
                for (int j=0, j2=0; j<Form1.UList[i].Count; j+=2, j2++)
                {
                    if (j2 >= crrow.Count) continue;
                    crrow[j2] = Form1.UList[i][j];
                    cbrow[j2] = Form1.VList[i][j];
                }
            }

            Form1.UList = new List<List<float>>(tempVList);
            Form1.VList = new List<List<float>>(tempUList);
        }
    }
}
