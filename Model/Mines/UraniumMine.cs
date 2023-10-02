﻿using Energetic_development.Data;

namespace Energetic_development.Model.Mines
{
    public class UraniumMine : BaseMine
    {
        public UraniumMine()
        {
            ProductionUnits = 100;
        }

        public void Work(ResourceStorage rs)
        {
            rs.UraniumStorage += ProductionUnits * Quantity;
        }
    }
}
