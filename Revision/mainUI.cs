using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using WindowsFormsApplication1.Properties;
using System.Collections.Generic;
using RskLib;

namespace WindowsFormsApplication1
{
    public partial class MainUI : Form
    {
        bool spots = true;
        string buscando = @"AUDIO\ADASCOM\";

        public MainUI()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnSwitch, "Clic aqui para buscar musica");
            this.ttMensaje.SetToolTip(this.btList, "Exportar listado a Excel");
            this.ttMensaje.SetToolTip(this.button1, "Buscar");
            this.ttMensaje.SetToolTip(this.btnAbout, "Acerca de...");
            this.ttMensaje.SetToolTip(this.btnConfig, "Configuración");
            this.ttMensaje.SetToolTip(this.btnClose, "Cerrar");

            //Recupera las siglas y rutas de las estaciones
            if (File.Exists("config.txt"))
            {
                string[] lineas = File.ReadAllLines("config.txt");
                int contLineas = lineas.Length;
                string[] siglas = new string[contLineas];
                string[] rutas = new string[contLineas];
                ExtConfig(siglas, rutas);
                this.cbSelec.Items.AddRange(siglas);
                this.cbSelec.Text = siglas[0];
            }
        }

        //Boton Revisar
        private async void BtRev_Click(object sender, EventArgs e)
        {
            pbLoader.Visible = true;
            pbLoader.Refresh();
            string archivo = "";
            string file = "";
            string ruta = "";
            string rutaAudio = "";
            DateTime inicio = fInic.Value;
            DateTime fin = fFin.Value;
            DateTime iniciaProceso = DateTime.Now;
            DateTime terminaProceso;
            List<Faltante> faltantes = new List<Faltante>();

            string[] lineas = File.ReadAllLines("config.txt");
            int contLineas = lineas.Length;
            string[] siglas = new string[contLineas];
            string[] rutas = new string[contLineas];
            ExtConfig(siglas, rutas);

            if (!dataGridView1.RowCount.Equals(0))
            {
                dataGridView1.Rows.Clear();
            }

            ruta = rutas[cbSelec.SelectedIndex];

            if (fInic.Value > fFin.Value)
            {
                MessageBox.Show("La fecha inical no puede ser mayor a la fecha final");
            }
            else
            {
                while (inicio.Ticks <= fin.Ticks)
                {
                    file = inicio.ToString("yyyyMMdd");
                    archivo = ruta + @"asciilist\" + cbSelec.SelectedItem + "_" + file + ".txt";
                    rutaAudio = ruta + buscando;

                    if (cbSelec.Visible == true)
                    {
                        BarraDeProgreso(inicio);

                        if (File.Exists(archivo))
                        {
                            faltantes = await ProtocRev(cbSelec.SelectedItem.ToString(), 
                                        archivo, rutaAudio, inicio, file);

                            foreach (var item in faltantes)
                            {
                                EscribeTabla(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El archivo " + cbSelec.SelectedItem.ToString() 
                                + "_" + file + ".txt no existe", "Advertencia");
                        }
                    }

                    #region rbTodas está seleccionado

                    else
                    {
                        for (int i = 0; i < cbSelec.Items.Count; i++)
                        {
                            cbSelec.SelectedIndex = i;
                            ruta = rutas[i];
                            BarraDeProgreso(inicio);
                            archivo = ruta + @"asciilist\" + cbSelec.SelectedItem + "_" + file + ".txt";
                            rutaAudio = ruta + buscando;
                            if (File.Exists(archivo))
                            {
                                faltantes = await ProtocRev(cbSelec.SelectedItem.ToString(), 
                                    archivo, rutaAudio, inicio, file);

                                foreach (var item in faltantes)
                                {
                                    EscribeTabla(item);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El archivo " + cbSelec.SelectedItem.ToString
                                    () + "_" + file + ".txt no existe", "Advertencia");
                            }
                        }
                    }

                    #endregion

                    inicio = inicio.AddDays(1);
                    lbProgreso.Text = "";
                }

                terminaProceso = DateTime.Now;
                Console.WriteLine("El proceso inicio a las " +
                iniciaProceso.ToString("hh:mm:ss"));
                Console.WriteLine("El proceso finalizo a las " +
                terminaProceso.ToString("hh:mm:ss"));
                pbLoader.Visible = false;
                MessageBox.Show("Busqueda Terminada a las " + terminaProceso.ToShortTimeString());
            }
        }

        private void BarraDeProgreso(DateTime inicio)
        {
            lbProgreso.Visible = true;
            lbProgreso.Text = "Leyendo " + cbSelec.SelectedItem.ToString() + " del dia " 
                + inicio.ToShortDateString();
            lbProgreso.Refresh();
        }

        //Protocolo de revisión.
        private async Task<List<Faltante>> ProtocRev(
            string estacion, string archivo, string rutaAudio, DateTime inicio, string file)
        {
            string x;
            string hora = "";
            int carpAudio = 00;
            string audio = "00";
            bool existe = false;
            string[] codigo = { "", "" };
            List<Faltante> faltantes = new List<Faltante>();

            using (StreamReader leer = new StreamReader(archivo))
            {
                await Task.Run(() =>
                {
                    while (!leer.EndOfStream)
                    {
                        x = leer.ReadLine();

                        if (x == "00:00:00")
                        {
                            hora = ObtieneHora(x, spots);
                        }
                        else if (x.Length > 10 && x.Substring(0, 1) == "#")
                        {
                            hora = ObtieneHora(x, spots);
                        }

                        codigo = SeparaCodigo(x, spots);

                        string directorio = rutaAudio + audio + @"\";

                        if (codigo[0] != "")
                        {
                            while (Directory.Exists(directorio))
                            {
                                string buscar = directorio + codigo[0] + ".wav";

                                if (File.Exists(buscar))
                                {
                                    existe = true;
                                    audio = "00";
                                    carpAudio = 0;
                                    break;
                                }
                                else { existe = false; }

                                carpAudio++;
                                audio = carpAudio.ToString();

                                if (audio.Length == 1)
                                {
                                    audio = "0" + audio;
                                }

                                directorio = rutaAudio + audio + @"\";
                            }

                            if (!existe)
                            {
                                Faltante faltante;
                                faltante = new Faltante(estacion, inicio.Date, hora, codigo[0], codigo[1]);
                                faltantes.Add(faltante);
                                audio = "00";
                                carpAudio = 0;
                            }
                        }
                    }
                });
            }


            return faltantes;
        }

        //Boton Radio todas
        private void EstTodas_CheckedChanged(object sender, EventArgs e)
        {
            cbSelec.Visible = false;
        }

        //Boton Radio Seleccionar
        private void EstSelec_CheckedChanged(object sender, EventArgs e)
        {
            cbSelec.Visible = true;
        }

        //Boton Listado a Excel
        private void BtList_Click(object sender, EventArgs e)
        {
            var excelApp = new excel.Application();
            excel.Workbooks book = excelApp.Workbooks;
            book.Add(true);
            excel.Range rango = excelApp.get_Range("A1", "E1");

            //extrae cabeceras
            int indiceColumna = 0;
            int indiceFila = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns) //Columnas
            {
                indiceColumna++;
                excelApp.Cells[1, indiceColumna] = col.Name;
            }

            //llena la tabla
            indiceFila = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns) // Filas
                {
                    indiceColumna++;
                    excelApp.Cells[indiceFila + 1, indiceColumna] = row.Cells
                    [col.Name].Value;
                    string fin = "E" + indiceFila.ToString();
                    rango = excelApp.Range["A1", fin];
                }
            }

            rango.Font.Name = "Verdana";
            excelApp.get_Range("A1", "E1").Font.Bold = true;
            excelApp.get_Range("A1", "E1").Interior.Color =
            System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            rango.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
            rango.Columns.AutoFit();
            excelApp.Visible = true;
        }

        //Bloque que escribe en la tabla sin repetir codigos.
        private void EscribeTabla(Faltante faltante)
        {
            bool flag = true;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == faltante.codigo &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString() == faltante.estacion)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                dataGridView1.Rows.Add(
                    faltante.estacion, faltante.fecha, 
                    faltante.hora, faltante.codigo, faltante.contrato);
            }
        }

        //Bloque que separa el codigo del contrato.
        private static string[] SeparaCodigo(string x, bool spots)
        {
            string[] codigo = { "", "" };
            if (spots)
            {
                if (x.Length > 15 && 
                    x.Length < 22 && 
                    x.Substring(0, 1) != "L" &&
                    x.Substring(0, 1) != "#")
                {
                    codigo = x.Split(',');
                }
            }
            else
            {
                if (x.Length > 1 && 
                    x.Length < 8 && 
                    x != "ADAS" && 
                    x != "1111111" && 
                    !char.IsNumber(x[0]) &&
                    x.Substring(0, 2) != "ID")
                {
                    codigo[0] = x;
                    codigo[1] = "";
                }
            }
            return codigo;
        }

        //Bloque que obiente la hora del corte.
        private static string ObtieneHora(string x, bool spots)
        {
            string hora = "";
            if (spots)
            {
                if (x.Substring(0, 4) == "#C C")
                {
                    hora = x.Substring(16, 8);
                }
            }
            else
            {
                if (x == "00:00:00") {
                    hora = x;
                }
                else if (x.Substring(0, 4) == "#C F")
                {
                    hora = x.Substring(20, 8);
                }
                else if (x.Substring(0, 2) == "#B")
                {
                    hora = x.Substring(3, 8);
                }
            }
            return hora;
        }

        //Lanza el módulo de informacion
        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asciiListDelForm adf = new asciiListDelForm();
            adf.ShowDialog();
        }

        //Lanza el módulo de configuración
        private void ConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            pass.ShowDialog(this);
        }

        //Extrae la información de configuración
        public static void ExtConfig(string[] siglas, string[] rutas)
        {
            Configuraciones.ExtConfig(siglas, rutas, "config.txt");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Cambia entre busqueda de musica y comerciales
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            if (spots)
            {
                this.btnSwitch.Image = Resources.btnMus;
                this.ttMensaje.SetToolTip(this.btnSwitch, "Clic para buscar comerciales");
                buscando = @"AUDIO\ADASMUS\";
                spots = false;
            }
            else
            {
                this.btnSwitch.Image = Resources.btnCom;
                this.ttMensaje.SetToolTip(this.btnSwitch, "Clic aqui para buscar musica");
                buscando = @"AUDIO\ADASCOM\";
                spots = true;
            }
        }

        //Lanza modulo de info al cliquear el logo
        private void imgLogo_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}