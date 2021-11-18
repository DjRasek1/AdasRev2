using System;
using System.Windows.Forms;
using System.IO;
using RskLib;

namespace WindowsFormsApplication1
{
    public partial class confUsuarios : Form
    {

        public confUsuarios()
        {
            InitializeComponent();


            if (File.Exists("userConfig.txt"))
            {
                int indice = 0;
                string[] lineas = File.ReadAllLines("userConfig.txt");
                int contLineas = lineas.Length;
                string[] siglas = new string[contLineas];
                string[] rutas = new string[contLineas];
                Configuraciones.ExtConfig(siglas, rutas, "userConfig.txt");

                foreach(string item in lineas){
                    dgConfig.Rows.Add(Seguridad.DesEncriptar(siglas[indice]), Seguridad.DesEncriptar(rutas[indice]));

                    indice++;
                }
            }
        }

        //Botón Agregar Usuario
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddUser nu = new AddUser();
            nu.ShowDialog();
            string idUser = nu.tbNewUser.Text;
            string idPass = nu.tbPass.Text;

            if (nu.DialogResult == DialogResult.OK)
            {
                dgConfig.Rows.Add(idUser, idPass);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgConfig.RowCount != 0)
                {
                int rowIndex = dgConfig.SelectedCells[0].OwningRow.Index;
                DataGridViewRow selectedRow = dgConfig.Rows[rowIndex];
                dgConfig.Rows.Remove(selectedRow); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (dgConfig.Rows.Count != 0)
            {
                MainUI f1 = new MainUI();

                if (File.Exists("userConfig.txt"))
                {
                    File.Delete("userConfig.txt");
                }

                File.Create("userConfig.txt").Close();

                using (StreamWriter sw = new StreamWriter("userConfig.txt"))
                {
                    int indiceFila = 0;
                    foreach (DataGridViewRow fila in dgConfig.Rows)
                    {
                        {
                            indiceFila++;
                            {
                                sw.WriteLine(Seguridad.Encriptar(fila.Cells[0].Value.ToString()) + "," + Seguridad.Encriptar(fila.Cells[1].Value.ToString()));
                            }
                        }
                    }
                }
                MessageBox.Show("Se han guardado los cambios.");

            }
            else {MessageBox.Show(this, "Debe agregar al menos un usuario", 
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarDataGrid(string datos)
        {
            if (File.Exists(datos))
            {
                int indice = 0;
                string[] lineas = File.ReadAllLines(datos);
                int contLineas = lineas.Length;
                string[] param1 = new string[contLineas];
                string[] param2 = new string[contLineas];
                Configuraciones.ExtConfig(param1, param2, datos);

                foreach (string item in lineas)
                {
                    dgConfig.Rows.Add(param1[indice], param2[indice]);
                    indice++;
                }
            }
        }
    }
}