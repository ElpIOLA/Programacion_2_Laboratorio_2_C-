using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06
{
  public partial class Form1 : Form
  {
    #region Atributos
    private EjercicioClase05.Tinta _tinta;
    private EjercicioClase05.Pluma _pluma;
    #endregion

    #region Constructor
    public Form1()
    { 
      InitializeComponent();
    }
    #endregion

    private void ssssssToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void tinataToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTinta form = new frmTinta();
      form.Show();
    }

    private void plumaToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
