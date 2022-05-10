using System;
using System.IO;
using RskLib;
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
    public partial class asciiListDelForm : Form
    {
        public asciiListDelForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ciclo = 0;
            string[] lineas = File.ReadAllLines("config.txt");
            int contLineas = lineas.Length;
            string[] siglas = new string[contLineas];
            string[] rutas = new string[contLineas];
            Configuraciones.ExtConfig(siglas, rutas, "config.txt");

            for (int i = 0; i < rutas.Length; i++)
            {   
                string directorio = rutas[i] + @"asciilist\";
                DateTime dateSelected = fecha.Value;
                dateSelected = dateSelected.AddDays(-1);
                string fechaAnt = dateSelected.ToString("yyyyMMdd");
                string archivo = directorio + siglas[i] + "_" + fechaAnt + ".txt";

                while (File.Exists(archivo))
                {
                    ciclo++;
                    File.Delete(archivo);
                    //paraPruebas += "\n" + archivo;
                    dateSelected = dateSelected.AddDays(-1);
                    fechaAnt = dateSelected.ToString("yyyyMMdd");
                    archivo = directorio + siglas[i] + "_" + fechaAnt + ".txt";
                }
            }
            if (ciclo > 0)
            {
                MessageBox.Show("Se eliminaron los ensambles anteriores a " + fecha.Value.ToLongDateString() + "." + 
                    "\nSe borraron " + ciclo + " ensambles.");
            }
            else
            {
                MessageBox.Show("No hay nada que borrar.");
            }
        }
    }
}