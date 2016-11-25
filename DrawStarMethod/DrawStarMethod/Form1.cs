using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStarMethod
{
    public partial class Form1 : Form
    {
        Graphics drawing;
        Pen whitePen;
        int cx, cy;
        int xCoord, yCoord, size;

        public Form1()
        {
            InitializeComponent();
            drawing = CreateGraphics();

            cx = this.Width - 80 / 2; cy = this.Height / 2;            
            whitePen = new Pen(Color.White);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            xCoord = Convert.ToInt32(xBox.Text);
            yCoord = Convert.ToInt32(yBox.Text);
            size = Convert.ToInt32(sizeBox.Text);
            DrawStar();
        }

        private void DrawStar(float xCoord, float yCoord, float size, EventArgs e)
        {
            drawing.DrawLine(whitePen, xCoord, yCoord, xCoord - 50, yCoord + 50);
            drawing.DrawLine(whitePen, xCoord, yCoord, xCoord + 50, yCoord + 50);            
        }
    }
}

