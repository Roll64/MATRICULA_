using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Matriculas.MODELS
{
    //public class Persona
    internal class Persona
    {

        private int id;
        private string dni;
        private string nombre;
        private string email;

        public Persona(int id, string dni, string nombre, string email)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.email = email;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }


        public virtual void Mostrar()
        {
            Console.WriteLine($"Id : {this.id}");
            Console.WriteLine($"DNI : {this.dni}");
            Console.WriteLine($"NOMBRE : {this.nombre}");
            Console.WriteLine($"EMAIL : {this.email}");
        }

    }
}
