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
    public partial class FrmTempera : Form
    {
        private Tempera _miTempera;

        public Tempera MiTempera { get { return this._miTempera; } }

        public FrmTempera()
        {
            InitializeComponent();

            this.label1.Text = "Color";
            this.label2.Text = "Marca";
            this.label3.Text = "Cantidad";
            this.button1.Text = "Aceptar";
            this.button2.Text = "Cancelar";
            this.comboColor.DropDownStyle = ComboBoxStyle.DropDown;
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboColor.Items.Add(color);
            }

            this.comboColor.Items.Add("Seleccione uno");
            this.comboColor.SelectedItem = "Seleccione uno";
            this.comboColor.SelectedItem = ConsoleColor.Cyan;
            this.comboColor.DropDownStyle = ComboBoxStyle.DropDownList;

            //Quitamos el Minimizar y el Agrandar.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FrmTempera(Tempera T) : this()
        {
            this._miTempera = T;
            this.comboColor.SelectedItem = T.GetColor;
            this.textCantidad.Text = "" + T.GetCantidad;
            this.textMarca.Text = T.GetMarca;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _miTempera = new Tempera(sbyte.Parse(this.textCantidad.Text), (ConsoleColor)this.comboColor.SelectedItem, this.textMarca.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
