using System;
using System.Collections.Generic;

namespace APIConsultaAspirante.DAL.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Descripcion { get; set; }

    public float Precio { get; set; }

    public int Estatus { get; set; }
}
