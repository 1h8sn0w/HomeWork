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
            park.AddNode(new Vehicle(2, "Tasya", 769));
            park.AddNode(new Vehicle(3, "Masya", 243));
            park.AddNode(new Vehicle(4, "Dasya", 124));
            park.AddNode(new Vehicle(5, "Gasya", 680));
            park.AddNode(new Vehicle(6, "Zasya", 346));
            


            Console.ReadKey();
        }
    }
}
