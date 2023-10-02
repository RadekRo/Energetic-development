using Energetic_development.Data;

namespace Energetic_development.Model.Mines
{
    public class MoonMine : BaseMine
    {
        public MoonMine()
        {
            ProductionUnits = 10;
        }
        public override void Work(ResourceStorage rs, int day)
        {
            rs.HeliumStorage += ProductionUnits * Quantity;
        }
    }
}
