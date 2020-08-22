using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastTwoPlanets = new List<string>() { };
            List<string> rockyPlanets = new List<string>() { };

            planetList.AddRange(new string[]
            {
                "Jupiter",
                "Saturn",
            });

            lastTwoPlanets.AddRange(new string[]
            {
                "Uranus",
                "Neptune",
            });

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus ");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            // add rocky planets to a list
            var rocky = planetList.GetRange(0, 4);
            foreach (var rock in rocky)
                rockyPlanets.Add(rock);
            
            
            // Displaying Rocky Planets
            Console.WriteLine("Rocky Planets");
            foreach (var rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);
            }
            

            planetList.Remove("Pluto");

            Console.WriteLine("\nAll of the Planets");
            // Displaying the rest of the planets

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }


            Console.WriteLine("\nDictionary Part");
            Dictionary<string, List<string>> spaceShip = new Dictionary<string, List<string>>();
            spaceShip.Add("Messenger", new List<string>() { "Mercury" });
            spaceShip.Add("Pioneer 10", new List<string>() { "Jupiter" });
            spaceShip.Add("Pioneer 11", new List<string>() { "Jupiter", "Saturn"});
            spaceShip.Add("Voyager 1", new List<string>() { "Jupiter", "Saturn" });
            spaceShip.Add("Voyager 2", new List<string>() { "Jupiter", "Saturn", "Uranus", "Neptune" });


            foreach (var p in planetList)
            {
                for (int index = 0; index < spaceShip.Count; index++)
                {
                    var item = spaceShip.ElementAt(index);
                    var spaceCraft = item.Key;
                    var planetVisited = item.Value;

                    foreach (var planet in planetVisited)
                    {
                        if (planet == p)
                        {
                            Console.WriteLine($"{planet}: {spaceCraft}");
                        }
                        
                    }

                }
            }

           

        }
    }
}
