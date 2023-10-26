using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Moto : Vehiculo
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
    }
}
