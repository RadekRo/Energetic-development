using Energetic_development.Model.EnergyConsumers;
namespace Energetic_development.Data
{
    public class InitialData
    {
        public void SetupApp(EnergyConsumers energyConsumers)
        {
            energyConsumers.AddConsumer("World", 6000000);
            energyConsumers.AddConsumer("Poland", 40000);
            energyConsumers.AddConsumer("New York", 10000);
        }
    }
}
