﻿using Energetic_development.Data;
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
            HadronCollider hadronCollider = new();
            ResourceStorage rs = new ResourceStorage();
            hadronCollider.Quantity = 1;
            for (int i = 1; i < 10; i++)
            {
                hadronCollider.Work(rs, i);
                Console.WriteLine($"Antimatter storage level: {rs.AntimatterStorage}");
            } 

        }
    }
}