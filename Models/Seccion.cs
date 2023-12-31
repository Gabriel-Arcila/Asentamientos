﻿using System;
using System.Collections.Generic;

namespace Asentamientos.Models;

public partial class Seccion
{
    public int IdSeccion { get; set; }

    public string Snombre { get; set; } = null!;

    public string? Sdescri { get; set; }

    public DateOnly SfechaCrea { get; set; }

    public bool Sestado { get; set; }

    public virtual ICollection<Variable> Variables { get; set; } = new List<Variable>();
}
