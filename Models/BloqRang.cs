﻿using System;
using System.Collections.Generic;

namespace Asentamientos.Models;

public partial class BloqRang
{
    public int IdBloqRang { get; set; }

    public int IdBloque { get; set; }

    public int IdRango { get; set; }

    public bool Brestado { get; set; }

    public virtual Bloque IdBloqueNavigation { get; set; } = null!;

    public virtual Rago IdRangoNavigation { get; set; } = null!;
}
