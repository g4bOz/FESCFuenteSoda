﻿using System;
using System.Collections.Generic;

namespace Backend.Models.Scaffold;

public partial class Producto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int CreatedBy { get; set; }

    public int UpdateBy { get; set; }

    public int Status { get; set; }
}
