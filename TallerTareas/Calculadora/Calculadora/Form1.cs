using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(int.Parse(textBox2.Text) * 12);
            datos0.Text = Convert.ToString((Double.Parse(textBox4.Text) * int.Parse(textBox2.Text))/100);
            label5.Text = Convert.ToString((Double.Parse(textBox5.Text) * int.Parse(textBox2.Text)) / 100);
            label10.Text = Convert.ToString((Double.Parse(textBox6.Text) * int.Parse(textBox2.Text)) / 100);
            label8.Text = Convert.ToString((Double.Parse(textBox1.Text) * int.Parse(textBox2.Text)) / 100);
            label12.Text = Convert.ToString((Double.Parse(textBox7.Text) * int.Parse(textBox2.Text)) / 100);
            label38.Text = Convert.ToString((Double.Parse(textBox16.Text) * int.Parse(textBox2.Text)) / 100);
            label15.Text = Convert.ToString((Convert.ToDouble(datos0.Text) + Convert.ToDouble(label5.Text)  + Convert.ToDouble(label10.Text) 
                + Convert.ToDouble(label8.Text) + Convert.ToDouble(label12.Text) + Convert.ToDouble(label38.Text) ));
            label24.Text = Convert.ToString((Double.Parse(textBox12.Text) * int.Parse(textBox2.Text)) / 100);
            label22.Text = Convert.ToString((Double.Parse(label24.Text) * int.Parse(textBox3.Text)));
            label20.Text = Convert.ToString((Double.Parse(textBox10.Text) * int.Parse(textBox2.Text)) / 100);
            label30.Text = Convert.ToString((Convert.ToDouble(label24.Text) + Convert.ToDouble(label22.Text) + Convert.ToDouble(label20.Text)
                + Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox14.Text) + Convert.ToDouble(textBox13.Text)));
            label32.Text = Convert.ToString((Double.Parse(label30.Text) + Double.Parse(label15.Text)));
            label34.Text = Convert.ToString((Double.Parse(label32.Text) + Double.Parse(textBox2.Text)));
            label36.Text = Convert.ToString((Double.Parse(textBox15.Text) * Double.Parse(label7.Text)) / 100);
        }
    }
}
