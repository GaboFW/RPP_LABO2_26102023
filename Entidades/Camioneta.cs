using System.Text;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        public Camioneta(EPropulsion propulsion, bool cabinaSimple)
            : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo: {this.Tipo}, Propulsion: {this.propulsion}, Cabina: {this.cabinaSimple}");

            return sb.ToString();
        }
    }
}
