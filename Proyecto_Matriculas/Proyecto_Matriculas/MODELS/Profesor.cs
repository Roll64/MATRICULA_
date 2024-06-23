using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Matriculas.MODELS
{
    internal class Profesor : Persona
    {

        //private string dni;
        private string especialidad;

        public Profesor(int id, string dni, string nombre, string email, string especialidad) : 
            base(id, dni, nombre, email)
        {
            this.especialidad = especialidad;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"ESPECIALIDAD : {this.especialidad}");
        }

    }
}
