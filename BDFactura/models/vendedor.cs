using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BDFactura.models
{
    public class vendedor
    {

        public int id { get; set; }
        [Required]
        public string nombre_comple { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo_electronico { get; set; }
        public string fecha_registro { get; set; }
        public string estado { get; set; }
        public int generoid { get; set; }
        [Required]
        public Genero genero { get; set; }







    }
}
