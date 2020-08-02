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
            IEnumerable<int> vs = Enumerable.Range(1, 10);
            Console.WriteLine(string.Join(",", MyFilter(vs)));
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

        
   

}
}
