using Energetic_development.Data;

namespace Energetic_development.Model.Mines
{
    public class HadronCollider : BaseMine
    {
        public HadronCollider()
        {
            ProductionUnits = 1;
            ProductionCycle = 7;
        }

        public void Work(ResourceStorage rs)
        {
            rs.AntimatterStorage += ProductionUnits * Quantity;
        }
    }
}
