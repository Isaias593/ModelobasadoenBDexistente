using System.ComponentModel.DataAnnotations;

namespace BDFactura.models
{
    public class Genero
    {
        public int id { get; set; }
        [Required]
        public string nombre_genero { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }
    }
}
