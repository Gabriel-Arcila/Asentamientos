﻿namespace Asentamientos.DTOs
{
    public class CorteDiscDTO
    {
        public int IdCorteDis { get; set; }

        public int IdCategori { get; set; }

        public string CdaccCorr { get; set; } = null!;

        public bool CdisListo { get; set; }

        public int IdAsenta { get; set; }

    }
}