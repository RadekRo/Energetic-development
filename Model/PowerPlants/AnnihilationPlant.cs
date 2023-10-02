using Energetic_development.Data;

namespace Energetic_development.Model.PowerPlants
{
    public class AnnihilationPlant : BasePowerPlant
    {
        public AnnihilationPlant()
        {
            ProductionUnits = 25000;
            ConsumptionUnits = 1;
        }

        public void Work(ResourceStorage storage)
        {

        }
    }
}