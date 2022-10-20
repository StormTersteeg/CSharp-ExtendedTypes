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
        
        /// <summary>
        /// Used like .reduce() in JavaScript.
        /// Iterate over the collection, and call a given lambda upon every item.
        /// </summary>
        public R Reduce<R>(Func<R, T, R> f, R initial_state)
        {
            R result = initial_state;
            foreach (T item in this) { result = f(result, item); }
            return result;
        }

        /// <summary>
        /// Used like .map() in JavaScript.
        /// Iterate over the collection, and call a given lambda upon every item.
        /// </summary>
        public EList<R> Map<R>(Func<T, R> f)
        {
            EList<R> result = new EList<R>();
            foreach (T item in this) { result.Add(f(item)); }
            return result;
        }
    }
}
