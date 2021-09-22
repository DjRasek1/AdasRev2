using System;
using System.Windows.Forms;
using System.IO;
using RskLib;

namespace WindowsFormsApplication1
{
    public partial class nvaConf : Form
    {
        bool estaciones = false;

        public nvaConf()
        {
            InitializeComponent();

            if (File.Exists("config.txt"))
            {
                int indice = 0;
                string[] lineas = File.ReadAllLines("config.txt");
                int contLineas = lineas.Length;
                string[] siglas = new string[contLineas];
                string[] rutas = new string[contLineas];
                MainUI.ExtConfig(siglas, rutas);

                foreach(string item in lineas){
                    dgConfig.Rows.Add(siglas[indice], rutas[indice]);
                    indice++;
                }
            }
        }

        //Botón Agregar Estación
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (estaciones)
            {
                NvaEst nueva = new NvaEst();
                nueva.ShowDialog();
                string ruta = nueva.tbRuta.Text;
                string Siglas = nueva.tbSiglas.Text;

                if (nueva.DialogResult == DialogResult.OK)
                {
                    ruta = ruta.Remove(ruta.Length - 7);
                    dgConfig.Rows.Add(Siglas, ruta);
                } 
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dgConfig.Rows.Count;

                // Obtiene el indice de la fila para la celda seleccionada
                int rowIndex = dgConfig.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;

                // obtiene el indice el a columna para la celda seleccionada
                int colIndex = dgConfig.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgConfig.Rows[rowIndex];
                dgConfig.Rows.Remove(selectedRow);
                dgConfig.Rows.Insert(rowIndex - 1, selectedRow);
                dgConfig.ClearSelection();
                dgConfig.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btDn_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dgConfig.Rows.Count;

                // Obtiene el indice de la fila para la celda seleccionada
                int rowIndex = dgConfig.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;

                // obtiene el indice el a columna para la celda seleccionada
                int colIndex = dgConfig.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgConfig.Rows[rowIndex];
                dgConfig.Rows.Remove(selectedRow);
                dgConfig.Rows.Insert(rowIndex + 1, selectedRow);
                dgConfig.ClearSelection();
                dgConfig.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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

                if (File.Exists("config.txt"))
                {
                    File.Delete("config.txt");
                }

                File.Create("config.txt").Close();

                using (StreamWriter sw = new StreamWriter("config.txt"))
                {
                    int indiceFila = 0;
                    foreach (DataGridViewRow fila in dgConfig.Rows)
                    {
                        {
                            indiceFila++;
                            {
                                sw.WriteLine(fila.Cells[0].Value + "," + fila.Cells[1].Value);
                            }
                        }
                    }
                }
                #region Recupera las siglas y rutas de las estaciones

                string[] lineas = File.ReadAllLines("config.txt");
                int contLineas = lineas.Length;
                string[] siglas = new string[contLineas];
                string[] rutas = new string[contLineas];

                MainUI.ExtConfig(siglas, rutas);

                f1.cbSelec.Items.AddRange(siglas);
                f1.cbSelec.Text = siglas[0];
                MessageBox.Show("Reinicie la aplicación para que los cambios tengan efecto");

                #endregion
                this.Close();

            } else {MessageBox.Show(this, "Debe agregar al menos una estación", 
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSwitch_Click(object sender, EventArgs e)
        {
            if (estaciones)
            {
                btnSwConfig("Siglas", "Ruta", "Agregar Estacion", 
                    "Eliminar Estacion", "Configuracion de Estciones");
                btUp.Show();
                btDn.Show();
                this.btnSwitch.Text = "Configuracion de Usuarios";
                this.btnSwitch.BackColor = System.Drawing.Color.Orange;
                this.btnSwitch.ForeColor = System.Drawing.Color.Black;
                llenarDataGrid("config.txt");
            }
            else
            {
                btnSwConfig("Usuarios", "", "Agregar Usuario",
                    "Eliminar Usuario", "Configuracion de Usuarios");
                btUp.Hide();
                btDn.Hide();
                this.btnSwitch.Text = "Configuracion de Estaciones";
                this.btnSwitch.BackColor = System.Drawing.Color.Blue;
                this.btnSwitch.ForeColor = System.Drawing.Color.White;
                llenarDataGrid("userConfig.txt");
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
                    if (estaciones)
                    {

                        dgConfig.Rows.Add(param1[indice], param2[indice]);
                    }
                    else
                    {
                        dgConfig.Rows.Add(Seguridad.DesEncriptar(param1[indice])); 
                    }
                    indice++;
                }
                estaciones = !estaciones;
            }
        }

        private void btnSwConfig(string header1, string header2, string btnAdd, 
            string btnDel, string formText)
        {
            dgConfig.Columns[0].HeaderText = header1;
            dgConfig.Columns[1].HeaderText = header2;
            dgConfig.Rows.Clear();
            btAdd.Text = btnAdd;
            btDel.Text = btnDel;
            Text = formText;
        }
    }
}