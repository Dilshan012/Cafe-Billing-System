using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Question03
{
    public partial class Form1 : Form
    {
        static int number = 1;
        int totaltea, totalmilk, totalcoffe;
        int tea, milk, coffee;
        int totalQty;
        int discount, finalDiscount, totalPrice;
        public Form1()
        {
            InitializeComponent();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox3.Text);
            number++;
            textBox3.Text = Convert.ToString(number);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = number.ToString();
            textBox2.Text = number.ToString();
            textBox3.Text = number.ToString();
            textBox4.Text = Convert.ToString("10%");
            textBox5.Text = Convert.ToString("30 Rs");
            textBox6.Text = Convert.ToString("270 Rs");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox2.Text);
            number--;
            if (number >= 0)
                textBox2.Text = Convert.ToString(number);

            else
                MessageBox.Show("Sorry. You cannot reduce the Milk Quantity below 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);
            number++;
            textBox1.Text = Convert.ToString( number);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);
            number--;

            if (number >= 0)
                textBox1.Text = Convert.ToString(number);

            else
                MessageBox.Show("Sorry. You cannot reduce the Tea Quantity below 0","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox2.Text);
            number++;
            textBox2.Text = Convert.ToString(number);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox3.Text);
            number--;
            if (number >= 0)
                textBox3.Text = Convert.ToString(number);

            else
                MessageBox.Show("Sorry. You cannot reduce the Coffee Quantity below 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tea = Convert.ToInt32( textBox1.Text);
            milk = Convert.ToInt32(textBox2.Text);
            coffee = Convert.ToInt32(textBox3.Text);

            totaltea = tea * 50;
            totalmilk = milk * 150;
            totalcoffe = coffee * 100;

            totalQty = totaltea + totalmilk + totalcoffe;

            discount = Convert.ToInt32(textBox4.Text.TrimEnd('%'));

            if (discount >= 0)
            {
                finalDiscount = totalQty * discount / 100;
                totalPrice = totalQty - finalDiscount;
                textBox5.Text = (finalDiscount.ToString() + " Rs");
                textBox6.Text = (totalPrice.ToString() + " Rs");
            }

            else
            {
                MessageBox.Show("Sorry. You cannot make the discount percentage a negative value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = Convert.ToString("0%");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private bool isMaximized = false;
        private Point restoreLocation;
        private Size restoreSize;

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                // Save the current location and size
                restoreLocation = this.Location;
                restoreSize = this.Size;

                // Maximize the form
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                // Restore the form to its previous location and size
                this.WindowState = FormWindowState.Normal;
                this.Location = restoreLocation;
                this.Size = restoreSize;
                isMaximized = false;
            }
        }

        // Handle form movement
        private Point lastLocation;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                lastLocation = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
