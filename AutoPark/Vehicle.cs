using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Vehicle
    {
        public Vehicle(int id, string name, int route)
        {
            Id = id;
            Name = name;
            Route = route;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Route { get; set; }

        public override bool Equals(object obj)
        {
            var vehicle = obj as Vehicle;
            return vehicle != null &&
                   Id == vehicle.Id &&
                   Name == vehicle.Name &&
                   Route == vehicle.Route;
        }

        public override int GetHashCode()
        {
            var hashCode = -569875532;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Route.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Route}";
        }
    }
}
