using Energetic_development.Model.EnergyConsumers;
using System.Text;
using System.Threading.Channels;

namespace Energetic_development.View
{
    public class Display
    {
        public Dictionary<string, int> avaliableFactoriesList = new Dictionary<string, int>();
        public Dictionary<string, int> Setup(EnergyConsumers consumers)
        {
            int id = 1;
            Console.WriteLine("ENTER SETUP DATA:");
            Console.WriteLine("POWER PLANTS: ");
            displayQtyQuestion("Coal Plants: ");
            getUserValue(avaliableFactoriesList, "Coal Plants");
            displayQtyQuestion("Solar Plants: ");
            getUserValue(avaliableFactoriesList, "Solar Plants");
            displayQtyQuestion("Nuclear Plants: ");
            getUserValue(avaliableFactoriesList, "Nuclear Plants");
            displayQtyQuestion("Fusion Plants: ");
            getUserValue(avaliableFactoriesList, "Fusion Plants");
            displayQtyQuestion("Annihilation Plants: ");
            getUserValue(avaliableFactoriesList, "Annihilation Plants");
            Console.WriteLine("MINES: ");
            displayQtyQuestion("Coal Mines: ");
            displayQtyQuestion("Uranium Mines: ");
            displayQtyQuestion("Moon Mines: ");
            displayQtyQuestion("Hadron Colliders: ");
            Console.WriteLine("CONSUMERS: ");
            foreach (var consumer in consumers.ConsumerNames) 
            {
                Console.WriteLine($"{id}. {consumer.Key}");
                id++;
            }
            Console.WriteLine("Enter the value of the consumer selected: ");

            return avaliableFactoriesList;
        }
        
        public void Result()
        {

        }

        public void displayQtyQuestion(string factory)
        {
            Console.Write($"Number of {factory}");
        }

        public void getUserValue(Dictionary<string, int> factoriesList,  string key)
        {
            var userInput = Console.ReadLine();
            factoriesList[key] = int.Parse(userInput);

        }
    }
}
