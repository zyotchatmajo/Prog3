using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Numerin = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 0;
            if (Int32.TryParse(textBox1.Text, out valor))
            {
                Numerin.Add(valor);
                textBox1.Text = "";
                MessageBox.Show("Agregado");
            }
            else
            {
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numerin.Sort();
            MessageBox.Show(Mostrar());
        }
        public String Mostrar()
        {
            String Lista = "";
            for (int i = 0; i < Numerin.Count; i++)
            {
                Lista += (i+1)+". " + Numerin[i];
                Lista += Environment.NewLine;
            }
            return Lista;
        }

        public void Add()
        {
            string filename = "Registro.txt";
            File.WriteAllText(filename, Mostrar());
            MessageBox.Show("Se escribio en el archivo");
        }
        public void Leer()
        {
            string line;
            string temp = "";
            Boolean isinfile = false;
            StreamReader file =
                new StreamReader("Registro.txt");
            while ((line = file.ReadLine()) != null)
            {
                temp += line;
                temp += Environment.NewLine; 
            }
            MessageBox.Show(temp);

            file.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Mostrar());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Leer();
        }
    }
}
