using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree park = new Tree();
            park.AddNode(new Vehicle(1, "Vasya", 111));
            park.AddNode(new Vehicle(2, "Tasya", 112));
            park.AddNode(new Vehicle(3, "Masya", 113));
            park.AddNode(new Vehicle(4, "Dasya", 114));
            park.AddNode(new Vehicle(5, "Gasya", 115));
            park.AddNode(new Vehicle(6, "Zasya", 116));
            


            Console.ReadKey();
        }
    }
}
