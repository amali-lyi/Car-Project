using System.Collections;
using System.Collections.Generic;

namespace MyProject
{
    class TransportPark : IEnumerable<IMovable>
    {
        List<IMovable> transports = new List<IMovable>();

        public void Add(IMovable transport)
        {
            transports.Add(transport);
        }

        public IEnumerator<IMovable> GetEnumerator()
        {
            return transports.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}