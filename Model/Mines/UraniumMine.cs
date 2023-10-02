using Energetic_development.Data;

namespace Energetic_development.Model.Mines
{
    public class UraniumMine : BaseMine
    {
        public UraniumMine()
        {
            ProductionUnits = 100;
        }

        public override void Work(ResourceStorage rs, int day)
        {
            rs.UraniumStorage += ProductionUnits * Quantity;
        }
    }
}
