using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A' && str[i] <= 'z'))
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }
        public static string RemoveAccents(string s)
        {
            Encoding destEncoding = Encoding.GetEncoding("iso-8859-8");

            return destEncoding.GetString(
                Encoding.Convert(Encoding.UTF8, destEncoding, Encoding.UTF8.GetBytes(s)));
        }

       
        String[] Predefinidos = new string[] {
        "¿Acaso hubo búhos acá?",
        "A la catalana banal, atácala.",
        "A mamá, Roma le aviva el amor a papá y a papá, Roma le aviva el amor a Mamá.",
        "A ti no, bonita.",
        "Amo la pacífica paloma.",
        "Amor a Roma.",
        "Ana lava lana."
                };

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textCampo.Text;
            String CadenaInvertida = Reverse(RemoveSpecialCharacters(RemoveAccents(a))).ToLower();
            String CadenaOriginal = RemoveSpecialCharacters(RemoveAccents(a)).ToLower();
            if (CadenaInvertida.Equals(CadenaOriginal))
            {
                label1.Text = "La cadena es un palindromo";
            }
            else
            {
                label1.Text = "La cadena no es un palindromo";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[1];
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[2];
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[3];
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[4];
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[5];
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textCampo.Text = Predefinidos[6];
        }
    }
}
