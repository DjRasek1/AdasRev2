using System;
using System.IO;
using System.Windows.Forms;
using RskLib;

namespace WindowsFormsApplication1
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines("userConfig.txt");
            int contLineas = lineas.Length;
            string[] users = new string[contLineas];
            string[] pass = new string[contLineas];

            Configuraciones.ExtConfig(users, pass, "userConfig.txt");

            string usuario = tbUser.Text;
            string password = tbPass.Text;

            bool auth = Seguridad.Validar(users, pass, usuario, password);

            if (auth)
            {
                nvaConf fc = new nvaConf();
                this.Hide();
                fc.ShowDialog();
                this.Close();
            }else {
                MessageBox.Show(this, "Acceso Denegado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPass.Text = "";
            }
        }

        private void Pass_Load(object sender, EventArgs e)
        { 
            if (!File.Exists("userConfig.txt"))
            {
                using (StreamWriter sw = new StreamWriter("userConfig.txt"))
                {
                    sw.WriteLine(Seguridad.Encriptar("DjRasek") + "," + Seguridad.Encriptar("Shortie"));
                }
            }
        }
    }
}