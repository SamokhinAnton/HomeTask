using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Iterators
    {
        public IEnumerable<T> F<T>(IEnumerable<T> arr)
        {
            foreach (var item in arr.Reverse())
            {
                yield return item;
            }
        }

        public IEnumerable<T> F3<T>(T[][] arr)
        {
            for (int i = 0; i < arr[0].Length; i++)
            {
                foreach (var item in arr)
                {
                    yield return item[i];
                }
            }
        }

        public IEnumerable<T> F4<T>(T[] arr)
        {
            var temp = new List<T>();
            foreach (var item in arr)
            {
                if (!temp.Contains(item))
                {
                    temp.Add(item);
                    yield return item;
                }
            }

        }
    }
}
