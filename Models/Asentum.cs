﻿using System;
using System.Collections.Generic;

namespace Asentamientos.Models;

public partial class Asentum
{
    public int IdAsenta { get; set; }

    public int IdRango { get; set; }

    public int IdInfoAse { get; set; }

    public double Avalor { get; set; }

    public bool AisActivo { get; set; }

    public virtual ICollection<CorteDi> CorteDis { get; set; } = new List<CorteDi>();

    public virtual InfoAse IdInfoAseNavigation { get; set; } = null!;

    public virtual Rago IdRangoNavigation { get; set; } = null!;
}
