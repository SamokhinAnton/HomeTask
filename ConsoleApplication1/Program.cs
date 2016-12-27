using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void D(int i);
    class Program
    {
        static void F(int i)
        {
            Console.WriteLine("fff");

        }
        static void G(int i)
        {
            Console.WriteLine("ggg");
        }

        static void MinusedInvoked(object sender, OpArgs args)
        {
            Console.WriteLine("minus was work with arguments {0}, {1}", args.A, args.B);
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] { 1,2,3,4},
                new int[] { 5,6,7,8},
                new int[] { 9,10,11,12}
            };
            var itere = new Iterators();
            var a = itere.F3(arr);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            var arr2 = new int[] { 1, 2, 2, 4, 5, 6, 2, 12, 2, 178, 4};
            var b = itere.F4(arr2);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            //Calc2 c = new Calc2();
            //c.Minused += MinusedInvoked;

            //Console.WriteLine(c.Plus(25, 20));
            //Console.WriteLine(c.Minus(-140, -20));
            //D @delegate = F;
            //@delegate += G;
            //@delegate(10);

            //var run = new Runner<decimal>(1, 2, 2, 4, 5, 6, 2, 12, 2, 178, 4);
            //foreach (var item in run)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerable<int> arr = new List<int>() { 0, 1, 2, 23, 2, 2, 2, 2, 5 };
            //var b = Uniq(arr);
            //foreach (var item in b)
            //{
            //    Console.WriteLine(item);
            //}
        }

        static List<T> Uniq<T>(IEnumerable<T> list)
        {
            List<T> result = new List<T>();
            foreach (var item in list)
            {
                if (!result.Any(x => x.Equals(item)))
                {
                    result.Add(item);
                }
            }
            return result;
        }


    }

}
