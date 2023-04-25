using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases3
{
    public class Llamada
    {

        public enum TipoLlamada 
        { 
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion 
        { 
            get { return duracion; } 
        }

        public string NroDestino 
        {
            get { return nroDestino; }
        }

        public string NroOrigen 
        {
            get { return nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar() 
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Nro. Destino: {nroDestino}");
            sb.AppendLine($"Nro. origen: {nroOrigen}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada l1, Llamada l2) 
        {
            if (l1.duracion > l2.duracion)
            {
                return 1;
            }
            else {
                if (l1.duracion < l2.duracion)
                {
                    return -1;
                }
                else {
                    return 0;
                }
            }
        }


    }
}
