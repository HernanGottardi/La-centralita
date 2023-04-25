using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases3
{
    public class Provincial: Llamada
    {
        public enum Franja 
        { 
            Franja_1 = 99, 
            Franja_2 = 125, 
            Franja_3 = 66
        }

        public Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino): base(duracion, destino, origen)
        { 
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto() 
        {
            return (duracion * (int)(franjaHoraria));
        }

        public float CostoLlamada 
        { 
            get { return CalcularCosto(); }
        }

        public string Mostrar() 
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Franja horaria: {franjaHoraria}");
            sb.AppendLine($"Duracion: {Duracion}");
            sb.AppendLine($"Origen: {NroOrigen}");
            sb.AppendLine($"Destino: {nroDestino}");
            sb.AppendLine($"Costo: {this.CalcularCosto()}");

            return sb.ToString();
        }


    }
}
