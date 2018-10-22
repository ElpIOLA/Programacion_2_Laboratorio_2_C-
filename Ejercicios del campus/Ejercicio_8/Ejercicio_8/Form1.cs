using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        Empresa empresa;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            TestEmpresa frm = new TestEmpresa(this.empresa);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.empresa = frm.Empresa;
            }
            else
            {
                this.Close();
            }

        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtLegajo.Text = "____.____.__";
            cmbPuesto.SelectedIndex = -1;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Empleado.EPuestoJerarquico puesto;
            int salario;

            if(!Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(),out puesto))
            {
                MessageBox.Show("Error en el combo de Puesto del empleado.");
                return;
            }
            if (!Int32.TryParse(mtxtSalario.Text.Substring(1, mtxtSalario.Text.Length - 1), out salario))
            {
                MessageBox.Show("Error en el salario del empleado.");
                return;
            }

            Empleado empleado = new Empleado(txtNombre.Text,txtApellido.Text,mtxtLegajo.Text,puesto,salario);
            empresa += empleado;

            rtxtConsola.Text = this.empresa.MostrarEmpresa();
        }

        
    }
}
