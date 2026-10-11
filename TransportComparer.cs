using System.Collections.Generic;

namespace MyProject
{
    class TransportComparer : IComparer<IMovable>
    {
        public int Compare(IMovable x, IMovable y)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name);
        }
    }
}