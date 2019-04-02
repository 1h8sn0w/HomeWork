using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class WeatherList : ICollection<Forecast>
    {
        List<string> temperarure = new List<string>();
        List<string> humidity = new List<string>();
        List<string> preassure = new List<string>();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Forecast item)
        {

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Forecast item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Forecast[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Forecast> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Forecast item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
