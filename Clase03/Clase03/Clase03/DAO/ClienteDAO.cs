using Clase03.BEAN;
using Clase03.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.DAO
{
    public class ClienteDAO
    {
        public void ListaClientesTipoDoc()
        {
            /*
             select cli.idCliente, cli.nombreCliente, cli.apellidosCliente, cli.numeroDocumentoCliente,
            td.nombreTipoDocumento, cat.nombreCategoria
            from tb_Cliente cli inner join tb_TipoDocumento td
            on cli.idTipoDocumento = td.idTipoDocumento inner join tb_Categoria cat
            on cli.idCategoria = cat.idCategoria
             */
            List<ClienteBEAN> listaCliente;
            using (var db= new conDB_EF())
            {
                var _Datos = from cli in db.tb_Cliente
                                 join td in db.tb_TipoDocumento on cli.idTipoDocumento equals td.idTipoDocumento
                                 select new ClienteBEAN
                                 {
                                     idCiente = cli.idCliente,
                                     nombreCliente = cli.nombreCliente,
                                     apellidosCliente = cli.apellidosCliente,
                                     numDocumento = cli.numeroDocumentoCliente,
                                     tipoDocumento = td.nombreTipoDocumento
                                 };
                listaCliente = _Datos.ToList();
            }
            Console.Clear();
            Console.WriteLine("Lista de Clientes y Tipo Documento");
            Console.WriteLine("Id \t Nombres \t Apellidos \t Num Doc \t Tipo Doc \t Categoría");
            foreach (var item in listaCliente)
            {
                Console.WriteLine(item.idCiente + "\t"
                    + item.nombreCliente + "\t\t"
                    + item.apellidosCliente + "\t\t"
                    + item.numDocumento + "\t\t"
                    + item.tipoDocumento);
            }
        }
    }
}
