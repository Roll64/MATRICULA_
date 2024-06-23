using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Matriculas.MODELS
{
    internal class Alumno : Persona
    {
        private string direccion;
        private int edad;

        public Alumno(int id, string dni, string nombre, string email, string direccion, int edad) : 
            base(id, dni, nombre, email)
        {
            this.direccion = direccion;
            this.edad = edad;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"EDAD : {this.edad}");
            Console.WriteLine($"DIRECCIÓN : {this.direccion}");
        }

    }
}
