using System.ComponentModel.DataAnnotations;

namespace BDFactura.models
{
    public class factura
    {
        public int id { get; set; }
        [Required]
        public int total { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }

        public int cantidad { get; set; }
        public double precio { get; set; }
        public double totalXproducto { get; set; }
    }
}
