using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NvaEst : Form
    {
        public NvaEst()
        {
            InitializeComponent();
        }

        //Botón Ruta
        private void button1_Click(object sender, EventArgs e)
        {
            fbDial1.ShowDialog();
            tbRuta.Text = fbDial1.SelectedPath;
        }

        //Botón Aceptar
        private void button2_Click(object sender, EventArgs e)
        {   
           if (tbRuta.TextLength.Equals(0) || tbSiglas.TextLength.Equals(0) || tbSiglas.Text == " " || tbRuta.Text == " ")
           {
               MessageBox.Show(this, "Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else
           {
               string ruta = tbRuta.Text;
               string siglas = tbSiglas.Text;
               if (ruta.Length < 7 || ruta.Substring(ruta.Length - 7, 7) != "ADASNET")
               {
                   MessageBox.Show(this, "Debe elejir una carpeta ADASNET", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else { this.DialogResult = DialogResult.OK; }
           }
        }
    }
}
