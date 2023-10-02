using Energetic_development.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energetic_development.Model
{
    public class BaseModel
    {
        public int ProductionUnits;
        public int ConsumptionUnits;
        public int ProductionCycle = 1;
        public int Quantity = 0;

        public void ChangeQuantity(int value)
        {
            Quantity = value;
        }
    }
}
