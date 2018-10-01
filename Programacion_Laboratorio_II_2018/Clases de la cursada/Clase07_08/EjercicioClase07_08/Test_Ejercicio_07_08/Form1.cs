using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Test_Ejercicio_07_08
{
    public partial class Form1 : Form
    {
        PaletaCollection miPaleta;
        public Form1()
        {
            InitializeComponent();
            this.miPaleta = 5;
            this.groupBox1.Text = "Paleta de Colores";

            this.btnAceptar.Text = "+";
            this.btnCancelar.Text = "-";

            this.groupBox1.Visible = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmTempera tempera = new FrmTempera();

            tempera.StartPosition = FormStartPosition.CenterScreen; //Centramos el formulario

            //Abrimos el formulario tempera y no dejamos que lo cierre a traves de X
            DialogResult rta = tempera.ShowDialog();

            if (rta == DialogResult.OK)
            {
                this.miPaleta += tempera.MiTempera;
                this.textBox1.Text = (string)miPaleta;
            }
                
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.groupBox1.Visible = true; // Hacemos visible el gruopBox1
            this.agregarPaletaToolStripMenuItem.Enabled = false; //Inabilitamos la creacion de paleta
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int i;
            string seleccionado = "";
            string[] texto = textBox1.Lines;
            seleccionado = textBox1.SelectedText;

            for(i = 2; i < textBox1.Lines.Count(); i++)
            {
                if(texto[i] == seleccionado)
                {
                    i -= 2;
                    MessageBox.Show("\nTempera seleccionada: " + seleccionado + "\nIndice: " + i);
                    break;
                }
            }

            FrmTempera frm = new FrmTempera(miPaleta[i]);
            DialogResult resultado = frm.ShowDialog();
        }
    }
}
