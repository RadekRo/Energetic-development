using Energetic_development.Data;

namespace Energetic_development.Model.Mines
{
    public class MoonMine : BaseMine
    {
        public MoonMine()
        {
            ProductionUnits = 10;
        }
        public void Work(ResourceStorage rs)
        {
            rs.HeliumStorage += ProductionUnits * Quantity;
        }
    }
}
