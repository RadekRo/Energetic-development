using Energetic_development.Data;
using Energetic_development.Model.EnergyConsumers;
using Energetic_development.Model.Mines;
using Energetic_development.View;
using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace Energetic_development
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jutabiście i piechnie!");
            ResourceStorage resourceStorage = new();
            Display display = new Display(); 
            EnergyConsumers ec = new(); 
            InitialData id = new InitialData();
            id.SetupApp(ec);
            Dictionary<string, int> listaSchindlera = display.Setup(ec);
            var listaSchindleraZwei = listaSchindlera.Where(x => x.Value > 0);
            foreach (var schindler in listaSchindleraZwei) 
            {
                Console.WriteLine($"{schindler.Key} : {schindler.Value}");
            }

        }
    }
}