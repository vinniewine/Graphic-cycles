using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_cycles
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            InitGraph();
        }
        public void InitGraph()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g =  Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.DarkRed);
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            g.Clear(pictureBox1.BackColor);
            RefreshPicture();
        }

        public void RefreshPicture()
        {
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawLine(pen, 0, 0, 300, 300);
            g.DrawLine(pen, 300, 0,0, 300);
            RefreshPicture();
        }
    }

}
