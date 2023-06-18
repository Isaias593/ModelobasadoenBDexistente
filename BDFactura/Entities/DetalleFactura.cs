using System;
using System.Collections.Generic;

namespace BDFactura.Entities;

public partial class DetalleFactura
{
    public int Id { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public int Facturaid { get; set; }

    public int Productoid { get; set; }

    public virtual Factura Factura { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
