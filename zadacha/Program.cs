using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
