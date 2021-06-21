using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    public class ClienteBEAN
    {
        //Uso del atajo propfull
        //Uso de atajo prop

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Carrera { get; set; }
        
        /*Métodos*/
        public string ConcatenarDatos()
        {
            string concatenado = "";
            /*Acciones según el método*/
            concatenado = Nombre + ", " + Apellido;
            return concatenado;
        }
        public string ConcatenarDatosConParametros(string pNombre, string pApellido)
        {
            string concatenado = "";
            concatenado = pNombre + ", " + pApellido;
            return concatenado;
        }
    }

}

