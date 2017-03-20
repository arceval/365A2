using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    class Export
    {
        public static void exportImage(Image outImage)
        {
            // convert image to YUV with 4:2:0 downsampling
            // 4:2:0 Sample the first pixel of a set, the second pixel is the copies the first, 
            // third is sampled, 4th is copied.
            // Every second line is just duplicated from the previous line.

            ConvertImage.toYUV444(outImage);
            ConvertImage.toYUV420();
            // run DCT transformation

            // put transform matrix into file
            
            // Encode into a text file
        }

    }
}
