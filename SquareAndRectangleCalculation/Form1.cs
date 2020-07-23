using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareAndRectangleCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int shortedge;
        int longedge;
        int field, perimeter;
        const int pi = 3;
        int r;

        private void button2_Click(object sender, EventArgs e)
        {
            shortedge = Convert.ToInt32(tbxShortEdge.Text);
             longedge = Convert.ToInt32(tbxLongEdge.Text);

            field = shortedge * longedge ;
            perimeter =( 2 * shortedge)+ (2 * longedge );
            lblField.Text = field.ToString();
            lblPerimeter.Text = perimeter.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            tbxShortEdge.Visible = true;
            label2.Visible = false;
            tbxLongEdge.Visible = false;
            label6.Visible = false;
            tbxRadius.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            tbxShortEdge.Visible = true;
            label2.Visible = true;
            tbxLongEdge.Visible = true;
            label6.Visible = false;
            tbxRadius.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            tbxShortEdge.Visible = false;

            label2.Visible = false ;
            tbxLongEdge.Visible = false ;

            label6.Visible = false;
            tbxRadius.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            tbxRadius.Visible  = true;
            label1.Visible = false;
            tbxShortEdge.Visible = false;

            label2.Visible = false;
            tbxLongEdge.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(tbxRadius.Text);
            field = pi * (r * r);
            perimeter = 2 * pi * r;
            lblField.Text = field.ToString();
            lblPerimeter.Text = perimeter.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shortedge = Convert.ToInt32(tbxShortEdge.Text);
            // longedge = Convert.ToInt32(tbxLongEdge.Text);

            field = shortedge * shortedge;
            perimeter = 4 * shortedge;
            lblField.Text = field.ToString();
            lblPerimeter.Text = perimeter.ToString();
        }
    }
}
