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
            string rpta = "N";
            do
            {
                RolDAO rolDAO = new RolDAO();
                Console.Clear();
                Console.WriteLine("Mantenimiento de Roles");
                Console.WriteLine("1 - Lista Roles ADO.NET");
                Console.WriteLine("5 - Lista Roles EF");
                Console.WriteLine("2 - Registro Roles");
                Console.WriteLine("3 - Registro & Listado de Roles");
                Console.WriteLine("4 - Buscar por ID");
                Console.WriteLine("0 - Salir");
                Console.Write("\nIngrese Opción: ");
                int opcion;
                opcion =Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        List<RolBEAN> ListaRol = new List<RolBEAN>();
                        ListaRol = rolDAO.ListaRoles();
                        Console.Clear();
                        Console.WriteLine("Lista Roles");
                        foreach (var item in ListaRol)
                        {
                            Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
                        }
                        Console.Write("¿Desea continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 2:
                        RolBEAN rolBEAN = new RolBEAN();
                        Console.Write("Ingres nombre de Rol: ");
                        rolBEAN.NombreRol = Console.ReadLine();
                        bool rptaReg = rolDAO.RegistrarRol(rolBEAN);
                        if (rptaReg)
                        {
                            Console.WriteLine("Registrado Correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Error en registro de Rol");
                        }
                        Console.Write("¿Desea continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 3:
                        RolBEAN rolBEAN2 = new RolBEAN();
                        Console.Write("Ingres nombre de Rol: ");
                        rolBEAN2.NombreRol = Console.ReadLine();
                        List<RolBEAN> listaRol = rolDAO.RegistroListadoRol(rolBEAN2);
                        foreach (var item in listaRol)
                        {
                            Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
                        }
                        Console.Write("¿Desea continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Ingrese IdRol a buscar: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        RolBEAN rolBEAN3 = new RolBEAN();
                        rolBEAN3 = rolDAO.BuscarRolByID(id);
                        if (rolBEAN3.IdRol == 0)
                        {
                            Console.WriteLine("Los registros con el Id en mención no existen");
                        }
                        else
                        {
                            Console.WriteLine(rolBEAN3.IdRol + " " + rolBEAN3.NombreRol);
                        }

                        Console.Write("¿Desea continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 5:
                        using (var db = new connBD_CONTACTABILIDAD())
                        {
                            List<tb_Rol> listaRoles = db.tb_Rol.ToList();
                            foreach (var item in listaRoles)
                            {
                                Console.WriteLine(item.idRol + " " + item.nombreRol);
                            }
                        }
                        Console.Write("¿Desea continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                }

            } while (rpta == "S" || rpta == "s");
        }
    }
}
