using System.ComponentModel.DataAnnotations;

namespace BDFactura.models
{
    public class cliente
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string correo_electronico { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }
        public int generoid { get; set; }
        [Required]
        public Genero Genero { get; }

    }
}
