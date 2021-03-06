using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class confMain : Form
    {
        public confMain()
        {
            InitializeComponent();
            AbrirFormulario<nvaConf>();
        }

        //Metodo para abrir formularios dentro del panel.
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false
                };
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnConfigEstacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<nvaConf>();
        }

        private void btnConfigUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario<confUsuarios>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea reiniciar la aplicación para aplicar los cambios?", "Atención", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Restart();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
