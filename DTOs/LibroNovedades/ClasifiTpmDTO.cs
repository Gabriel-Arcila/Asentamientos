﻿using System;
using System.Collections.Generic;

namespace Asentamientos.DTOs.LibroNovedades;
public partial class ClasifiTpmDTO
{
    public int IdCtpm { get; set; }

    public string Ctpmnom { get; set; } = null!;

    public bool Ctpmestado { get; set; }
}
