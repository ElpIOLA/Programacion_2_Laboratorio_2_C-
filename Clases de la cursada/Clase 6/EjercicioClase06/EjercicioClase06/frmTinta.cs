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
  public partial class frmTinta : Form
  {

    public frmTinta()
    {
      InitializeComponent();

      foreach (ConsoleColor _tinta in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.cboColor.Items.Add(_tinta);
      }

      cboColor.SelectedItem = ConsoleColor.Black; //Selecciona un elemento
      cboColor.DropDownStyle = ComboBoxStyle.DropDownList; //Inpide que el usuario escriba en el comboBox

      foreach(ETipoTinta _TipoTinta in Enum.GetValues(typeof(ETipoTinta)))
      {
        this.cboTipoTinta.Items.Add(_TipoTinta);
      }

       cboTipoTinta.SelectedItem = ETipoTinta.comun;
       cboTipoTinta.DropDownStyle = ComboBoxStyle.DropDownList;

    }

    private void frmTinta_Load(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
  }
}
