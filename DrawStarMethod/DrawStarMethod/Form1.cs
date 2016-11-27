using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStarMethod
{
    public partial class Form1 : Form
    {
        Graphics drawing;
        Pen whitePen;
        int xCoord, yCoord, size;
        bool resize;

        public Form1()
        {
            InitializeComponent();
                   
            whitePen = new Pen(Color.White);
            errorLabel.Text = "Maximum draw space of 500x500";
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawing = CreateGraphics();
            errorLabel.Text = "";
            drawing.Clear(Color.Black);
            try
            {
                xCoord = Convert.ToInt32(xBox.Text) + 80;
                yCoord = Convert.ToInt32(yBox.Text);
                size = Convert.ToInt32(sizeBox.Text);
            }
            catch
            {
                errorLabel.Text = "Error, did you input a number?";
            }
            if (size * size > 900 && !resize)
            {
                this.Width += 500;
                this.Height += 500;
                resize = true;
                drawButton.PerformClick();
                this.Refresh();
            }            
            DrawStar(xCoord, yCoord, size, e);
        }

        private void DrawStar(int xCoord, int yCoord, int size, EventArgs e)
        {
            int xrectMid = xCoord + size / 2;
            int yrectMid = yCoord + size / 2;
            int oneThird = size / 3;
            drawing.DrawRectangle(whitePen, xCoord, yCoord, size, size);

            Point[] star = new Point[11];
            #region Star point array
            //first half of star
            star[0] = new Point(xrectMid, yCoord);
            star[1] = new Point(xCoord + oneThird, yCoord + oneThird);
            star[2] = new Point(xCoord, yCoord + oneThird);
            star[3] = new Point(xCoord + oneThird - size / 13, yCoord + 2 * oneThird - size / 13); 
            star[4] = new Point(xCoord + size / 14, yCoord + size);
            star[5] = new Point(xrectMid, yCoord + size - 2 * oneThird / 3);
            //second half of star
            star[6] = new Point(xCoord + size - size / 14, yCoord + size);
            star[7] = new Point(xCoord + size - oneThird + size / 13, yCoord + 2 * oneThird - size / 13); 
            star[8] = new Point(xCoord + size, yCoord + oneThird);
            star[9] = new Point(xCoord + size - oneThird, yCoord + oneThird);
            star[10] = new Point(xrectMid, yCoord);
            drawing.DrawLines(whitePen, star);
            //drawing.DrawLine(new Pen(Color.Red), star[1], star[9]);     //to test straightness
            #endregion
        }
    }
}

