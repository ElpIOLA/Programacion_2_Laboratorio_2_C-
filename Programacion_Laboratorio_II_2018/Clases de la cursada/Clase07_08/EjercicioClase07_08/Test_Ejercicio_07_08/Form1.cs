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
        Paleta miPaleta;
        public Form1()
        {
            InitializeComponent();
            this.miPaleta = 5;
            this.groupBox1.Text = "Paleta de Colores";
            this.textBox1.Multiline = true; //Hace que el textBox se expanda con un enter
            this.btnAceptar.Text = "+";
            this.btnCancelar.Text = "-";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FrmTempera tempera = new FrmTempera();

            tempera.StartPosition = FormStartPosition.CenterScreen; //Centramos el formulario

            //Abrimos el formulario tempera y no dejamos que lo cierre a traves de X
            DialogResult rta = tempera.ShowDialog();

            if(rta == DialogResult.OK)
                this.miPaleta += tempera.MiTempera;
                this.textBox1.Text = (string)tempera.MiTempera;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true; // Hacemos visible el gruopBox1
            this.agregarPaletaToolStripMenuItem.Enabled = false; //Inabilitamos la creacion de paleta
        }
    }
}
