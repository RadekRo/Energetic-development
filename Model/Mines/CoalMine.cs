using Energetic_development.Data;
using System.Reflection;

namespace Energetic_development.Model.Mines
{
    public class CoalMine : BaseMine
    {
        public CoalMine()
        {
            ProductionUnits = 40;
        }

        public void Work(ResourceStorage rs)
        {
            rs.CoalStorage += ProductionUnits * Quantity;
        }
    }
    
}
