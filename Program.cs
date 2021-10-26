using System;
using System.Collections.Generic;
using HopClassLib;


namespace HopConsole
{
    class Program
    {
     





        static void Main(string[] args)
        {
            List<Hop> Hops = new List<Hop>
            {
                new Hop {Id = 1, Name = "1", HarvestYear = 1, AlphaAcid = 1, Price = 1},
                new Hop {Id = 2, Name = "2", HarvestYear = 2, AlphaAcid = 2, Price = 2}

            };
            foreach (Hop h in Hops)
            {
                Console.WriteLine($"ID :{h.Id} Name : {h.Name}, HarvestYear : {h.HarvestYear}, AlphaAcid : {h.AlphaAcid} Price : {h.Price}");
                
            }





        }
    }
}
