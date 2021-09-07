using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forma_grafica_desprendible
{
    class Nomina
    {
        public string Nombre { get; set; }
        public int Identificacion { get; set; }
        public string Cargo { get; set; }
        public string Genero { get; set; }
        public int Diastrabajados { get; set; }
        public decimal AsignacionDias { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public decimal CalcularNomina(int diaslab, decimal valorDia){
            decimal valorDevengado = 0;
            decimal bono = 40000;
            if(diaslab >= 15)
            {
                valorDevengado = diaslab * valorDia + bono;
            }
            else 
            {
                valorDevengado = diaslab * valorDia;
            }
            return valorDevengado;
        }

    }
}
