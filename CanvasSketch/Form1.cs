using System;
using System.Drawing;
using System.Windows.Forms;

namespace CanvasSketch
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    Color drawColor = Color.Black; // Default color if no radio button is checked

                    if (radioButton1.Checked)
                        drawColor = Color.Red;
                    else if (radioButton2.Checked)
                        drawColor = Color.Green;
                    else if (radioButton3.Checked)
                        drawColor = Color.Yellow;
                    else if (radioButton4.Checked)
                        drawColor = Color.Black;
                  

                    graphics.FillEllipse(new SolidBrush(drawColor), e.X, e.Y, 4, 4);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
