using Clase03.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.DAO
{
    public class CategoriaDAO
    {
        public void ListaCategoria()
        {
            Console.Clear();
            List<tb_Categoria> listaCat = new List<tb_Categoria>();
            using (var db = new conDB_EF())
            {
                listaCat = db.tb_Categoria.ToList();
            }
            Console.WriteLine("Lista de Categoría");
            foreach (var item in listaCat)
            {
                Console.WriteLine(item.idCategoria + " " + item.nombreCategoria);
            }
        }
        public void RegistraCategoria()
        {
            Console.Clear();
            Console.WriteLine("Registro Categoría");
            Console.Write("\nIngrese nombre categoría: ");
            string nombreCat = Console.ReadLine();
            tb_Categoria categoria = new tb_Categoria { nombreCategoria = nombreCat };
            using (var db = new conDB_EF())
            {
                db.tb_Categoria.Add(categoria);
                db.SaveChanges();
            }
            Console.WriteLine("Se registró correctamente");
        }

        public void EditarCategoria()
        {
            Console.Clear();
            ListaCategoria();
            Console.Write("\nIngrese el ID de Categoría a editar: ");
            int idCat = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el nuevo nombre: ");
            string nombreCat = Console.ReadLine();
            using (var db= new conDB_EF())
            {
                tb_Categoria cat = db.tb_Categoria.Find(idCat);
                cat.nombreCategoria = nombreCat;
                db.SaveChanges();
                Console.WriteLine("El registro con código " + idCat + " se editó correctamente.");
            }
        }
        public void EliminarCategoria()
        {
            Console.Clear();
            ListaCategoria();
            Console.Write("\nIngrese el ID de Categoría a eliminar: ");
            
            int idCat = Convert.ToInt32(Console.ReadLine());
            using (var db= new conDB_EF())
            {
                db.tb_Categoria.Remove(db.tb_Categoria.Find(idCat));
                db.SaveChanges();
            }
        }
    }
}
