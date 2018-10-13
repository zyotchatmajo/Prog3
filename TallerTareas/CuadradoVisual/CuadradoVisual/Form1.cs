using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadradoVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public int calculoperimetro(int bas, int alt)
        {
            return (bas * 2) + (alt * 2);
        }

        public int calculoarea(int bas, int alt)
        {
            return bas * alt;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int bas = 0;
            int alt = 0;
            try
            {
                bas = int.Parse(txtBot.Text);
                alt = int.Parse(txtRight.Text);
                if(bas == 0 || alt == 0)
                {
                    MessageBox.Show("Introduce un valor diferente a 0");
                }
                else
                {
                    int per = calculoperimetro(bas, alt);
                    int area = calculoarea(bas, alt);
                    Perimetro.Text = "Perimetro = " + per.ToString();
                    Area.Text = "Area = " + area.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Introduce un valor valido");
            }
        }
    }
}
