using System;
using System.Windows.Forms;
using System.IO;
using RskLib;

namespace WindowsFormsApplication1
{
    public partial class nvaConf : Form
    {

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
            NvaEst nueva = new NvaEst();
            nueva.ShowDialog();
            string ruta = nueva.tbRuta.Text;
            string Siglas = nueva.tbSiglas.Text;

            if (nueva.DialogResult == DialogResult.OK)
            {
                ruta = ruta.Remove(ruta.Length - 7);
                dgConfig.Rows.Add(Siglas, ruta);
                btOk.Enabled = true;
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
                btOk.Enabled = true;
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
                btOk.Enabled = true;
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
                    btOk.Enabled = true;
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
                MessageBox.Show("Se han guardado los cambios");
                btOk.Enabled = false;

            } else {MessageBox.Show(this, "Debe agregar al menos una estación", 
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