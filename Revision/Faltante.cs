using System;

namespace WindowsFormsApplication1
{
    public class Faltante
    {
        public string estacion, hora, codigo, contrato;
        public DateTime fecha;

        public Faltante(string estacion, DateTime fecha, string hora, string codigo, string contrato)
        {
            this.estacion = estacion;
            this.fecha = fecha;
            this.hora = hora;
            this.codigo = codigo;
            this.contrato = contrato;
        }
    }
}
