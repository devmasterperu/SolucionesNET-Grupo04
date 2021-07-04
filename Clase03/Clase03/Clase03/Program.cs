using Clase03.DAO;
using Clase03.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista Categoría con EF
            //conDB_EF connDB = new conDB_EF();
            //List<tb_Categoria> listaCat = new List<tb_Categoria>();
            //using (var db = new conDB_EF())
            //{
            //    listaCat = db.tb_Categoria.ToList();
            //}
            //Console.WriteLine("Lista de Categoría");
            //foreach (var item in listaCat)
            //{
            //    Console.WriteLine(item.idCategoria + " " + item.nombreCategoria);
            //}
            #endregion

            #region Registrar Categoría con EF

            //Console.Write("Ingrese nombre categoría: ");
            //string nombreCat = Console.ReadLine();
            //tb_Categoria cat = new tb_Categoria { nombreCategoria = nombreCat };
            //using (var db = new conDB_EF())
            //{
            //    db.tb_Categoria.Add(cat);
            //    db.SaveChanges();
            //}

            #endregion

            CategoriaDAO catDAO = new CategoriaDAO();
            ClienteDAO cliDAO = new ClienteDAO();
            //catDAO.RegistraCategoria();
            //catDAO.ListaCategoria();
            string rpta = "N";
            int codMenu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al mantenimiento de Categoría");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1-Lista");
                Console.WriteLine("2-Registro");
                Console.WriteLine("3-Editar");
                Console.WriteLine("4-Eliminar");
                Console.WriteLine("5-Lista Clientes");
                Console.WriteLine("\n0-Salir");
                Console.Write("Ingrese el código del menú:");
                codMenu = Convert.ToInt32(Console.ReadLine());
                switch (codMenu)
                {
                    case 1:
                        catDAO.ListaCategoria(); 
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine(); break;

                    case 2:
                        catDAO.RegistraCategoria();
                        catDAO.ListaCategoria(); 
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine(); break;
                    case 3:
                        catDAO.EditarCategoria();
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 4:
                        catDAO.EliminarCategoria();
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 5:
                        cliDAO.ListaClientesTipoDoc();
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por su visita.");
                        rpta = "N";
                        break;
                    default:
                        Console.WriteLine("Valor ingresado incorrecto");
                        Console.Write("¿Desea continuar?(S/N)");
                        rpta = Console.ReadLine();
                        break;
                }
            } while (rpta == "S" || rpta == "s");

            Console.ReadLine();
        }
    }
}
