using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto (EPropulsion propulsion) 
            : base (propulsion)
        {

        }

        protected override string Tipo
        { 
            get
            {
                return "Moto";
            }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo: {this.Tipo}, Propulsion: {this.propulsion}");

            return sb.ToString();
        }
    }
}
