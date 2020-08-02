using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_practicesVB
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            //Assignment 1
            IEnumerable<int> filterList = Enumerable.Range(1, 10);
            Console.WriteLine(string.Join(",", MyFilter(filterList)));

            //Assignment 2
            var a = Enumerable.Range(1, 5);
            var b = Enumerable.Range(1, 10).Where(x => x % 2 != 0);
            Console.WriteLine(string.Join(",", Merge(a,b)));

            //Assignment 3
            int[] list3 = { -3, -1, 3, 7, 1, -3, 7 };
            Console.WriteLine(LengthOfPositive(list3));

            //Assignment 4
            int polyInt = 2;
            int[] coeffs = {3, 4, 5};
            Console.WriteLine(Poly(polyInt, coeffs));

        }
        public static IEnumerable<int> MyFilter(IEnumerable<int> input)
        {
            //Alternative 1
            //var evens = input.Where(x => x % 2 == 0);
            //var squared = evens.Select(x => x * x);
            //var result = squared.Where(x => x < 50);

            //Alternative 2
            var result = input.Where(x => x % 2 == 0).Select(y => y * y).Where(z => z < 50);

            return result;
        }

        public static IEnumerable<int> Merge(IEnumerable<int> a, IEnumerable<int> b)
        {
            return a.Except(b).Union(b.Except(a));
        }

        public static int LengthOfPositive(IEnumerable<int> input)
        {
            return input.Skip(2).TakeWhile(i => i > 0).Count();
        }

        public static int Poly(int x, IEnumerable<int> coeffs)
        {
            int degree = coeffs.Count() - 1;
            return coeffs.Aggregate(0, (p, x1) => (p + x1 * (int)Math.Pow(x, degree--)));
        }



    }
}
