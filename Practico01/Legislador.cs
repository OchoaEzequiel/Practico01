using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    internal class Legislador
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string casado;
        protected string partido;
        protected string departamento;
        protected int despacho;
        public Legislador(string nombre, string apellido, int edad, string casado, string partido, string departamento, int despacho)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
            this.partido = partido;
            this.departamento = departamento;
            this.despacho = despacho;
        }

        public string getNombre() { return this.nombre; }
        public string getApellido() { return this.apellido; }
        public int getEdad() { return this.edad; }
        public string getCasado() { return this.casado; }
        public string getPartido() { return this.partido; }
        public string getDepartamento() { return this.departamento; }
        public int getDespacho() { return this.despacho; }

        public string getCamara()
        {
            if(despacho <= 50)
            {
                return "Senado";
            }
            else
            {
                return "Diputados";
            }
        }
        public virtual void presentarPropuesta(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha presentado una propuesta");
        }
        public virtual void votar(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha votado");
        }
        public virtual void participarDebate(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha participado en un debate");
        }
    }
}
