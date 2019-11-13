using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{


    public class Cliente
    {
        public Cliente(string nombres, string apellidos, string numeroDeCedula, string direccion)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            NumeroDeCedula = numeroDeCedula;
            Direccion = direccion;
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string numeroDeCedula;

        public string NumeroDeCedula
        {
            get { return numeroDeCedula; }
            set { numeroDeCedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}
