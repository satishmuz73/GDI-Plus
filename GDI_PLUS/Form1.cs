using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_PLUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, 50, 40, 110, 120);
            SolidBrush sd = new SolidBrush(Color.Red);
            g.FillRectangle(sd, 50, 40, 110, 120);
            Rectangle R = new Rectangle(30, 20, 80, 90);
            LinearGradientBrush b = new LinearGradientBrush(R, Color.Pink, Color.Blue, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, R);
        }
    }
}
