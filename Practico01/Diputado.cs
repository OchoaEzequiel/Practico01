﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    internal class Diputado : Legislador
    {
        private int NumAsientoCamaraBaja;
        public Diputado(string nombre, string apellido, int edad, string casado, string partido, string departamento, int despacho)
            : base(nombre, apellido, edad, casado, partido, departamento, despacho)
        {
            this.NumAsientoCamaraBaja = despacho;
        }
        public int getNumAsientoCamaraBaja() { return this.NumAsientoCamaraBaja; }
        public override void presentarPropuesta(int despacho)
        {
            Console.WriteLine("El Diputado " + nombre + " " + apellido + " ha presentado una propuesta");
        }
        public override void votar(int despacho)
        {
            Console.WriteLine("El Diputado " + nombre + " " + apellido + " ha votado");
        }
        public override void participarDebate(int despacho)
        {
            Console.WriteLine("El Diputado " + nombre + " " + apellido + " ha participado en un debate");
        }
    }
}
