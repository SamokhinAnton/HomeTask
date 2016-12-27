using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Runner<T> : IEnumerable<T>
    {
        private T[] _enumerator;

        public Runner(params T[] arr)
        {
            _enumerator = arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _enumerator)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
