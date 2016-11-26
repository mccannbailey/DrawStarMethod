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

            cx = size / 2;            
            whitePen = new Pen(Color.White);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawing.Clear(Color.Black);
            try
            {
                xCoord = Convert.ToInt32(xBox.Text) + 80;
                yCoord = Convert.ToInt32(yBox.Text);
                size = Convert.ToInt32(sizeBox.Text);
            }
            catch
            {
                
            }

            if (yCoord > 300 || xCoord > 300 || size > 300)
            {
                this.Width += 500;
                this.Height += 500;
            }
            DrawStar(xCoord, yCoord, size, e); 
        }

        private void DrawStar(float xCoord, float yCoord, float size, EventArgs e)
        {
            drawing.DrawRectangle(whitePen, xCoord, yCoord, size, size);
            //drawing.DrawLine(whitePen, cx, yCoord, cx - 25, cy + 25);                        
        }
    }
}

