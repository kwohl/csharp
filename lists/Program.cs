using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
        // Practice: Planet and Spaceships

            // // In the Main method, place the following code
            // List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // // Add() Jupiter and Saturn at the end of the list.
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");
            // foreach( string planet in planetList )
            // {
            //     Console.WriteLine(planet);
            // }

            // // Create another List that contains that last two planet of our solar system
            // List<string> outerPlanetList = new List<string>(){"Neptune", "Uranus"};
            // Console.WriteLine();
            // Console.WriteLine("Outer Planets:");
            // foreach( string planet in outerPlanetList )
            // {
            //     Console.WriteLine(planet);
            // }
            // // Combine the two lists by using AddRange()
            // planetList.AddRange(outerPlanetList);
            // Console.WriteLine();
            // foreach( string planet in planetList )
            // {
            //     Console.WriteLine(planet);
            // }

            // // Use Insert() to add Earth, and Venus in the correct order
            // planetList.Insert(1, "Venus");
            // planetList.Insert(2, "Earth");
            // Console.WriteLine();
            // foreach( string planet in planetList )
            // {
            //     Console.WriteLine(planet);
            // }

            // // Use Add() again to add Pluto to the end of the list
            // planetList.Add("Pluto");
            // Console.WriteLine();
            // foreach( string planet in planetList )
            // {
            //     Console.WriteLine(planet);
            // }

            // // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            // List<string> rockyPlanetList = new List<string>(){};
            // rockyPlanetList = planetList.GetRange(0, 4);
            // Console.WriteLine();
            // Console.WriteLine("Rocky Planets:");
            // rockyPlanetList.ForEach(planet => Console.WriteLine(planet));

            // // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList
            // planetList.Remove("Pluto");
            // Console.WriteLine();
            // planetList.ForEach(planet => Console.WriteLine(planet));
        

        //PRACTICE: RANDOM NUMBERS
            // Use the following code to create a list of random numbers. Each number will be between 0 and 5.
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
        
            for (int i=0; i<numbers.Count; i++) {
            // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i)) {
                    Console.WriteLine("numbers list contains " + i);
                } else {
                    Console.WriteLine("numbers list does not contain " + i);
                }
            }
        
        
        
        
        }
    }
}