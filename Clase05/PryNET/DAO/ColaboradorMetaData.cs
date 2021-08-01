using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    [MetadataType(typeof(tb_Colaborador.Metadata))]
    public partial class tb_Colaborador
    {
        public class Metadata
        {
            [Display(Name ="ID")]
            public int idColaborador { get; set; }
            [Display(Name = "Nombre")]
            public string nombreColaborador { get; set; }
            [Display(Name = "Apellido")]
            public string apellidoColaborador { get; set; }
            [Display(Name = "Num Doc.")]
            public string numeroDocumentoColaborador { get; set; }
            public int idRol { get; set; }
            public int idTipoDocumento { get; set; }
            public Nullable<int> idubigeo { get; set; }
            public string nombUser { get; set; }
        }
    }
}
