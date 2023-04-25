using System.Text;
using static clases3.Llamada;

namespace clases3
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get { return listaDeLLamadas; }
        }

        public float GananciaPorLocal
        {
            get
            {
                float ganancia = 0;

                foreach (var llamada in listaDeLLamadas)
                {
                    if (llamada is Local)
                    {
                        Local local = (Local)llamada;
                        ganancia += local.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                float ganancia = 0;

                foreach (var llamada in listaDeLLamadas)
                {
                    if (llamada is Provincial)
                    {
                        Provincial prov = (Provincial)llamada;
                        ganancia += prov.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciaPorTotal
        {
            get { return this.GananciaPorProvincial + this.GananciaPorLocal; }
        }

        public Centralita()
        {
            this.listaDeLLamadas = new List<Llamada> ();
        }

        public Centralita(string nombreEmpresa) : this() 
        { 
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            if (tipo == TipoLlamada.Local)
            {
                return this.GananciaPorLocal;
            }
            if (tipo == TipoLlamada.Provincial)
            {
                return this.GananciaPorProvincial;
            }
            else
            {
                return this.GananciaPorTotal;
            }

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciaPorTotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciaPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciaPorProvincial}");

            foreach (var llamada in listaDeLLamadas)
            {
                sb.AppendLine($"Ganancia Detalle llamadas: {llamada.Duracion}");
                sb.AppendLine($"Ganancia Detalle llamadas: {llamada.NroDestino}");
                sb.AppendLine($"Ganancia Detalle llamadas: {llamada.NroOrigen}");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas() 
        {
            
            if (listaDeLLamadas is not null) 
            {
               
                listaDeLLamadas.Sort((llamada1, llamada2) => llamada1.Duracion.CompareTo(llamada2.Duracion));
            }
           
        }
    }
}