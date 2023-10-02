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

        public override void Work(ResourceStorage rs, int day)
        {
            rs.AntimatterStorage += ProductionUnits * Quantity;
        }
    }
}
