using System.Diagnostics.Contracts;
using System.Text;

namespace Energetic_development.Model.EnergyConsumers
{
    public class EnergyConsumers
    {
        public int EnergyConsumption;
        public Dictionary<string, int> ConsumerNames;

        public EnergyConsumers() 
        {
           ConsumerNames = new Dictionary<string, int>();
        }

        public void AddConsumer(string consumerName, int energyConsumption) 
        {
            ConsumerNames[consumerName] = energyConsumption;
        }

        public int GetConsumer(string consumer)
        {
            return ConsumerNames[consumer];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var consumer in ConsumerNames)
            {
                sb.AppendLine(consumer.Key + ": " + consumer.Value);
            }
            return sb.ToString();
        }
    }
}
