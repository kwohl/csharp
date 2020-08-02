using System;
using System.Collections.Generic;

namespace PlanetsAndProbes
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create a list with all eight planets.

            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};

        // Create a list containing KeyValuePairs. Each KeyValuePair will hold the name of a spacecraft that we have launched, and the name of a planet that it has visited. The key of the KeyValuePair will be the probe name, and the value will be the planet it visited.

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();
        
        // Add some planet/probe combinations to the list

            probeDestinations.Add(new KeyValuePair<string, string> ("Messenger", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Mariner 2", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Galileo", "Earth"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Opportunity", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Cassini", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Voyager 1", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Voyager 2", "Uranus"));
            probeDestinations.Add(new KeyValuePair<string, string> ("Voyager 2", "Neptune"));
            probeDestinations.Add(new KeyValuePair<string, string> ("New Horizons", "Pluto"));
        
        // Iterate over planetList, and inside that loop, iterate over the list of key-value pairs. Write to the console, for each planet, which probes have visited it.
        
            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach(KeyValuePair<string, string> destination in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (destination.Value == planet) {
                        matchingProbes.Add(destination.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                string destinations = String.Join(", ", matchingProbes);
                Console.WriteLine($"{planet}: {destinations}");
            }
        
        }
    }
}
