using Energetic_development.Model.EnergyConsumers;
using System.Text;

namespace Energetic_development.View
{
    public class Display
    {
        public void Setup(EnergyConsumers consumers)
        {
            int id = 1;
            Console.WriteLine("ENTER SETUP DATA:");
            Console.WriteLine("POWER PLANTS: ");
            displayQtyQuestion("Coal Plants");
            displayQtyQuestion("Solar Plants");
            displayQtyQuestion("Nuclear Plants");
            displayQtyQuestion("Fusion Plants");
            displayQtyQuestion("Annihilation Plants");
            Console.WriteLine("MINES: ");
            displayQtyQuestion("Coal Mines");
            displayQtyQuestion("Uranium Mines");
            displayQtyQuestion("Moon Mines");
            displayQtyQuestion("Hadron Colliders");
            Console.WriteLine("CONSUMERS: ");
            foreach (var consumer in consumers.ConsumerNames) 
            {
                Console.WriteLine($"{id}. {consumer.Key}");
                id++;
            }
            Console.WriteLine("Enter the value of the consumer selected: ");
        }
        
        public void Result()
        {

        }

        public void displayQtyQuestion(string factory)
        {
            Console.WriteLine($"Number of {factory}");
        }
    }
}
