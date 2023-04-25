using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases3
{
    public class Local : Llamada
    {
        protected float costo;

        // LOS CONSTR A REVISAR A LA REVIVESERIA.
    
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen) 
        { 
            this.costo = costo;
        }

        public Local(Llamada l, float costo) : this(l.NroOrigen, l.Duracion, l.NroDestino, costo)
        {
        }

        public float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto() 
        {
            return duracion * costo;
        }

        public string Mostrar() 
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Origen nro: {nroOrigen}");
            sb.AppendLine($"Destino nro: {NroDestino}");
            sb.Append($"Duracion: {duracion}");
            sb.Append($"Precio: {costo}");
            sb.AppendLine($"Costo: {this.CalcularCosto()}");

            return sb.ToString();
        }
    }
}
