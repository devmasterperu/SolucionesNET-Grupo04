using Clase04.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.DAO
{
    public class RolDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        public List<RolBEAN> ListaRoles()
        {
            List<RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_ROL_List",conexion) )
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                rol = new RolBEAN();
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = Convert.ToString(datos[1]);
                                lista.Add(rol);
                            }
                        }
                    }
                    //se rompe el comando
                }
                //se rompe la cadena de conexión
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }
    }
}
