﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }

            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculo1 in fabrica.vehiculos)
            {
                if (vehiculo == vehiculo1)
                {
                    fabrica.vehiculos.Remove(vehiculo1);
                    break;
                }
            }

            return fabrica;
        }
    }
}