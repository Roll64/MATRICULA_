using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto_Matriculas.DAO;
using Proyecto_Matriculas.UTILS;

namespace Proyecto_Matriculas.UI
{
    internal abstract class UI
    {

        const int ANCHO = 50;
        protected Mensaje mensaje = new Mensaje(ANCHO);

        public abstract void MostrarMenu();

    }
}
