using Clase04.BEAN;
using Clase04.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RolBEAN> ListaRol = new List<RolBEAN>();
            RolDAO rolDAO = new RolDAO();
            ListaRol = rolDAO.ListaRoles();
            foreach (var item in ListaRol)
            {
                Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
            }
        }
    }
}
