using System;
using System.Collections.Generic;

namespace planner
{
    // Define class here
    public class Building
    {
    //constructor
        public Building(string address, string designer) {
            _address = address;
            _designer = designer;
        }
    //public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        //read-only
        public double Volume {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
    //private fields
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

    //public methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }
        public void Report()
        {
            Console.WriteLine(_address);
            Console.WriteLine("----------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}