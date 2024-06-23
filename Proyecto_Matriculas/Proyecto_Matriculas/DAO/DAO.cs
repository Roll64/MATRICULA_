using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto_Matriculas.MODELS;
using Proyecto_Matriculas.UTILS;

namespace Proyecto_Matriculas.DAO
{
    //public abstract class DAO
    internal abstract class DAO
    {
        protected Mensaje mensaje = new Mensaje(50);
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();

    }
}
