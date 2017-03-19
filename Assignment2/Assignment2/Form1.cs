using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            Background.setBackground(pictureBox1, openFileDialogBG);
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            Foreground.setForeground(pictureBox1, openFileDialogS);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export.exportImage(pictureBox1.Image);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Import.importImage(openFileDialogImport);
        }

    }
}
