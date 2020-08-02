using System;
using System.Collections.Generic;

namespace car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take the following JavaScript data structure that represents car sales and convert it to C# Lists and Dictionaries.
            // "vehicles": [
            //     {
            //         "vehicle": {
            //             "year": "2008",
            //             "model": "Damfresh",
            //             "make": "Biotraxquote",
            //             "color": "sky magenta"
            //         },
            //         "sales_agent": {
            //             "mobile": "(896) 478-6975",
            //             "last_name": "Botsford",
            //             "first_name": "Shaina"
            //         },
            //         "credit": {
            //             "credit_provider": "J.P.Morgan Chase & Co",
            //             "account": "601109582720302"
            //         }
            //     },
            //     {
            //         "vehicle": {
            //             "year": "2010",
            //             "model": "Hotquadtrax",
            //             "make": "Transtintechno",
            //             "color": "robin egg blue"
            //         },
            //         "sales_agent": {
            //             "mobile": "562.300.2912",
            //             "last_name": "Davis",
            //             "first_name": "Gerardo"
            //         },
            //         "credit": {
            //             "credit_provider": "PNC Financial Services",
            //             "account": "34578280562836"
            //         }
            //     }
            // ]

            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();
            
            vehicles.Add(new Dictionary<string, Dictionary<string, string>>() {
                {"vehicle", new Dictionary<string, string> () {
                    {"year", "2008"},
                    {"model", "Damfresh"},
                    {"make", "Biotraxquote"},
                    {"color", "sky magenta"}
                }},
                {"salesAgent", new Dictionary<string, string> () {
                    {"mobile", "(896) 478-6975"},
                    {"lastName", "Botsford"},
                    {"firstName", "Shaina"}
                }},
                {"credit", new Dictionary<string, string> () {
                    {"creditProvider", "J.P.Morgan Chase & Co"},
                    {"account", "601109582720302"}
                }}
            });
            
            vehicles.Add(new Dictionary<string, Dictionary<string, string>>() {
                {"vehicle", new Dictionary<string, string> () {
                    {"year", "2010"},
                    {"model", "Hotquadtrax"},
                    {"make", "Transtintechno"},
                    {"color", "robin egg blue"}
                }},
                {"salesAgent", new Dictionary<string, string> () {
                    {"mobile", "562.300.2912"},
                    {"lastName", "Davis"},
                    {"firstName", "Gerardo"}
                }},
                {"credit", new Dictionary<string, string> () {
                    {"creditProvider", "PNC Financial Services"},
                    {"account", "34578280562836 "}
                }}
            });

            for (int i=0; i<vehicles.Count; i++) {
                int vehicleCount = i + 1;
                Console.WriteLine("-----");
                Console.WriteLine($"VEHICLE {vehicleCount}");
                Console.WriteLine("-----");
                foreach (KeyValuePair<string, Dictionary<string, string>> infoCategory in vehicles[i]) {
                    Console.WriteLine($"{infoCategory.Key.ToUpper()} INFO");
                    foreach (KeyValuePair<string, string> data in infoCategory.Value) {
                        Console.WriteLine($"{data.Key}: {data.Value}");
                    }
                    Console.WriteLine();
                }
            }
            // foreach (KeyValuePair<string, string> info in )
            
            // Console.WriteLine(vehicles[0]["vehicle"]["year"]);

        }
    }
}
