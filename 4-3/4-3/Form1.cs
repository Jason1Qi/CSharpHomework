using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string color;
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            int n = Convert.ToInt32(textBox1.Text);
            double leng = Convert.ToDouble(textBox2.Text);
            double per1 = Convert.ToDouble(textBox3.Text);
            double per2 = Convert.ToDouble(textBox4.Text);
            double th1 = Convert.ToInt32(textBox5.Text) * Math.PI / 180;
            double th2 = Convert.ToInt32(textBox6.Text) * Math.PI / 180;
            color = checkedListBox1.Text;
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2,th1,th2,per1,per2);
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n=10,double x0=200,
            double y0=310,double leng=100,
            double th= -Math.PI / 2, double th1 = 30 * Math.PI / 180,
            double th2 = 20 * Math.PI / 180, double per1 = 0.6,
            double per2 = 0.7)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,th1, th2, per1, per2);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,th1, th2, per1, per2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            if (color=="红色")
            graphics.DrawLine(
 
               Pens.Red,
               (int)x0, (int)y0, (int)x1, (int)y1);
            if (color == "绿色")
                graphics.DrawLine(

                   Pens.Green,
                   (int)x0, (int)y0, (int)x1, (int)y1);
            if (color == "蓝色")
                graphics.DrawLine(

                   Pens.Blue,
                   (int)x0, (int)y0, (int)x1, (int)y1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
