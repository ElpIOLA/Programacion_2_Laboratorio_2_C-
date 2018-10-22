using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            string texto = rtxtTexto.Text.Trim();

            int contador = 0;

            foreach(string palabra in texto.Split(' '))
            {
                if (!string.IsNullOrEmpty(palabra))
                {
                    txtResultado.Text += "* " + palabra;
                    contador++;

                    if (contador >= 20)
                        break;
                }
            }
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            int cantidadPalabras = 0;
            int cantidadFinalizaLA = 0;

            string texto = rtxtTexto.Text.Trim();

            foreach(string s in texto.Split(' '))
            {
                if(!string.IsNullOrEmpty(s))
                {
                    cantidadPalabras += 1;

                    if (s.Length >= 2)
                        if (s.ToLower().LastIndexOf("la") == s.Length - 2)
                            cantidadFinalizaLA += 1;
                }
            }
            lblCantidadFinalizadaLA.Text = cantidadFinalizaLA.ToString();
            lblCantidadPalabras.Text = cantidadPalabras.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            // Calculo el valor máximo para substring
            //         = CONDICION ? true : false;
            int valMax = rtxtTexto.Text.Length >= 100 ? 100 : rtxtTexto.Text.Length;

            txtResultado.Text = rtxtTexto.Text.Substring(0, valMax);
        }

        private string buscarPalabraFinalizadaEn(string contenidoFinal, short cantidadAEncontrar)
        {

        }
    }
}
