using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ti_ti_ta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void check()
        {
            String nombre = Nombre.Text;
            if (Nombres.Contains(nombre))
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = false;
            }
        }
        public String getFecha()
        {
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("es-MX");
            return localDate.ToString(culture);
        }
        public void registro()
        {
            int counter = 0;
            string line;
            string temp = "";
            Boolean isinfile = false;
            StreamReader file =
                new StreamReader("Registro.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(Nombre.Text))
                {
                    temp += line +'\n';
                    isinfile = true;
                }
                counter++;
            }
            if (isinfile)
            {
                MessageBox.Show(temp);
            }
            else
            {
                MessageBox.Show("No se encontro esa persona");
            }
            
            file.Close();
        }
        public void Add(string nuevo)
        {
            string filename = "Registro.txt";
            File.AppendAllText(filename, nuevo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nuevo = Nombre.Text + " - Entrada - " + getFecha() + Environment.NewLine;
            Add(nuevo);
            Nombres.Add(Nombre.Text);
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nuevo = Nombre.Text + " - Salida - " + getFecha() + Environment.NewLine;
            Add(nuevo);
            Nombres.Remove(Nombre.Text);
            check();
        }

        ArrayList Nombres = new ArrayList();
        ArrayList Listini = new ArrayList();
        ArrayList Cola = new ArrayList();
        String allcola = "";
        private void Nombre_MouseLeave(object sender, EventArgs e)
        {
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cola.Add(Nombre.Text);
            MessageBox.Show("Se agrego el nombre " + Nombre.Text);
            allcola += Nombre.Text + "\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(allcola);
        }
        public void Simular()
        {
            Random rnd = new Random();
            int numerin = rnd.Next(3, 6);
            Console.WriteLine(this.Name+" Entro");
            for (int i = 0; i < numerin; i++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine(this.Name + " Salio despues de " + numerin + " Segundos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String test = "";
            while(Cola.Count != 0)
            {
                test = Cola[0].ToString();
                Thread thread1 = new Thread(Simular);
                thread1.Name = test;
                thread1.Start();
                Cola.RemoveAt(0);
            }
        }
    }
}
