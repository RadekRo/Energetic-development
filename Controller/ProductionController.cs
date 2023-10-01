using Energetic_development.Model.Mines;

namespace Energetic_development.Controller
{
    public class ProductionController
    {
        public void CreateFactory(string factoryName, int qty)
        {
            switch (factoryName) 
            {
                case "CoalMine":
                    if (qty > 0) 
                    {
                        CoalMine cm = new CoalMine();
                        cm.Quantity = qty;
                    }
                    break;
            }
        }
    }
}
