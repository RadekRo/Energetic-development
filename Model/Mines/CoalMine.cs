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

        public override void Work(ResourceStorage rs, int day)
        {
            rs.CoalStorage += ProductionUnits * Quantity;
        }
    }
    
}
