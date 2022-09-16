using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedList
{
    internal class EList<T> : List<T>
    {
        public override string ToString()
        {
            return String.Join(", ", this);
        }
        
        public R Reduce<R>(Func<R, T, R> f, R initial_state)
        {
            R result = initial_state;
            foreach (T item in this) { result = f(result, item); }
            return result;
        }
    }
}
