using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto_Matriculas.MODELS;
using Proyecto_Matriculas.UTILS;

namespace Proyecto_Matriculas.DAO
{
    //public class ProfesorDAO
    internal class ProfesorDAO : DAO
    {

        private List<Profesor> listaProfesor = new List<Profesor>();

        private Profesor FindValue()
        {
            Console.WriteLine($"INGRESE N° DNI DEL PROFESOR:");
            string dni = Console.ReadLine();

            Profesor profesor = listaProfesor.Find(a => a.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase));
            return profesor;
        }

        public override void Create()
        {
            base.mensaje.mostrarTitulo("REGISTRO DE NUEVO PROFESOR");

            Console.WriteLine("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("N° DNI : ");
            string dni = Console.ReadLine();
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("ESPECIALIDAD : ");
            string especialidad = Console.ReadLine();

            Profesor nuevoProfesor = new Profesor(id, dni, nombre, email, especialidad);
            listaProfesor.Add(nuevoProfesor);
         
            base.mensaje.mostrarMensaje("PROFESOR REGISTRADO CON EXITO!!");
        }

        public override void Read()
        {
            base.mensaje.mostrarTitulo("RELACIÓN DE PROFESORES");
            foreach (var profesor in listaProfesor)
            {
                Console.WriteLine(new string('*', 50));
                profesor.Mostrar();
            }
        }

        public override void Update()
        {
            base.mensaje.mostrarTitulo("ACTUALIZAR DATOS DE PROFESOR");
            Profesor profesor = this.FindValue();
            if (profesor != null)
            {
                Console.WriteLine("NUEVO NOMBRE : ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA ESPECIALIDAD : ");
                string nuevaEspecialidad = Console.ReadLine();

                profesor.Nombre = nuevoNombre;
                profesor.Email = nuevoEmail;
                profesor.Especialidad = nuevaEspecialidad;

                this.mensaje.mostrarMensaje("PROFESOR ACTUALIZADO CON EXITO !!!");

            }
            else
            {
                this.mensaje.mostrarMensaje("PROFESOR NO ENCONTRADO ....");
            }
        }

        public override void Delete()
        {
            base.mensaje.mostrarTitulo("ELIMINAR PROFESOR");
            Profesor profesor = this.FindValue();
            if (profesor != null)
            {
                listaProfesor.Remove(profesor);
                this.mensaje.mostrarMensaje("PROFESOR ELIMINADO CON EXITO !!!");
            }
            else
            {
                this.mensaje.mostrarMensaje("PROFESOR NO ENCONTRADO ....");
            }

        }


    }
}
