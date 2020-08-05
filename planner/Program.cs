using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue", "Katie Wohl");
            FiveOneTwoEight.Width = 54.5;
            FiveOneTwoEight.Depth = 54.5;
            FiveOneTwoEight.Stories = 3;
            
            Building ThreeFourSixEight = new Building("346 8th Avenue", "Katie Wohl");
            ThreeFourSixEight.Width = 37.25;
            ThreeFourSixEight.Depth = 54.5;
            ThreeFourSixEight.Stories = 5;

            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Emily Wohl");
            
            ThreeFourSixEight.Construct();
            ThreeFourSixEight.Purchase("Roxanne Nasraty");

            List<Building> RealEstate = new List<Building>();
            RealEstate.Add(FiveOneTwoEight);
            RealEstate.Add(ThreeFourSixEight);

            foreach (Building building in RealEstate)
            {
                building.Report();
                Console.WriteLine();
            }
        }
    }
}
