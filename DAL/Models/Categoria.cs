using System;
using System.Collections.Generic;

namespace APIConsultaAspirante.DAL.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Categoria1 { get; set; }

    public int? Estatus { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaActualizacion { get; set; }
}
