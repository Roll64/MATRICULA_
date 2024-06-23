using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto_Matriculas.MODELS;
using Proyecto_Matriculas.UTILS;

namespace Proyecto_Matriculas.DAO
{
    //public class AlumnoDAO
    internal class AlumnoDAO: DAO
    {

        private List<Alumno> listaAlumno = new List<Alumno>();

        private Alumno FindValue()
        {
            Console.WriteLine($"INGRESE N° DNI DEL ALUMNO:");
            string dni = Console.ReadLine();

            Alumno alumno = listaAlumno.Find(a => a.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }

        public override void Create()
        {
            base.mensaje.mostrarTitulo("REGISTRO DE NUEVO ALUMNO");

            Console.WriteLine("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("N° DNI : ");
            string dni = Console.ReadLine();
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("CORREO : ");
            string email = Console.ReadLine();
            Console.WriteLine("DIRECCIÓN : ");
            string direccion = Console.ReadLine();
            Console.WriteLine("EDAD : ");
            int edad = int.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(id, dni, nombre, email, direccion, edad);
            listaAlumno.Add(nuevoAlumno);
         
            base.mensaje.mostrarMensaje("PROFESOR REGISTRADO CON EXITO!!");
        }

        public override void Read()
        {
            base.mensaje.mostrarTitulo("RELACIÓN DE ALUMNOS");
            foreach (var alumno in listaAlumno)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }

        public override void Update()
        {
            base.mensaje.mostrarTitulo("ACTUALIZAR DATOS DE ALUMNO");
            Alumno alumno = this.FindValue();
            if (alumno != null)
            {
                Console.WriteLine("NUEVO NOMBRE : ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO CORREO : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA DIRECCIÓN : ");
                string nuevaDireccion = Console.ReadLine();
                Console.WriteLine("NUEVA EDAD : ");
                int nuevaEdad = int.Parse(Console.ReadLine());

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail;
                alumno.Direccion = nuevaDireccion;
                alumno.Edad = nuevaEdad;

                this.mensaje.mostrarMensaje("ALUMNO ACTUALIZADO CON EXITO !!!");
            }
            else
            {
                this.mensaje.mostrarMensaje("ALUMNO NO ENCONTRADO ....");
            }

        }

        public override void Delete()
        {
            base.mensaje.mostrarTitulo("ELIMINAR ALUMNO");
            Alumno alumno = this.FindValue();
            if (alumno != null)
            {
                listaAlumno.Remove(alumno);
                this.mensaje.mostrarMensaje("ALUMNO ELIMINADO CON EXITO !!!");
            }
            else
            {
                this.mensaje.mostrarMensaje("ALUMNO NO ENCONTRADO ....");
            }
        }



    }
}
