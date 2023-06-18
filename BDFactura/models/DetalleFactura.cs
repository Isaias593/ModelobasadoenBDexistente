using System.ComponentModel.DataAnnotations;

namespace BDFactura.models
{
    public class DetalleFactura
    {
        public int id { get; set; }
        [Required]
        public int cantidad { get; set; }
        public double precio { get; set; }

        public int facturaid { get; set; }
        public factura Factura { get; set; }

        public int productoid { get; set; }
        public producto Producto { get; set; }
    }
}
