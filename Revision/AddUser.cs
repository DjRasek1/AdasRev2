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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbConf.TextLength.Equals(0) || tbConf.Text == " " ||
                tbNewUser.TextLength.Equals(0) || tbNewUser.Text == " " ||
                tbPass.TextLength.Equals(0) || tbPass.Text == " ")
            {
                MessageBox.Show(this, "Debe llenar todos los campos", "Atención", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbPass.Text != tbConf.Text)
            {
                MessageBox.Show(this, "La contraseña y su confirmacion no pueden ser diferentes",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string idUser = tbNewUser.Text;
                string password = tbPass.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
