using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<double>();

            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Napishi 10 chisla lek: ");
                queue.Enqueue(double.Parse(Console.ReadLine()));
            }

            
            Console.WriteLine("Posledno vuvedenoto chislo : " + queue.Last());

            
            Console.WriteLine("Nai malkoto chislo: " + queue.Min());

            
            Console.Write("Chislata mejdu 5 i 15: ");
            bool neshto = false;
            foreach (double element in queue)
            {
                if (element >= 5 && element <= 15)
                {
                    Console.Write(element + " ");
                    neshto = true;
                }
            }
            if (!neshto)
            {
                Console.WriteLine("Nqma");
            }
            else
            {
                Console.WriteLine();
            }

            
            Console.Write("Chisla po red ako ima vuvedena nula: ");
            neshto = false;
            foreach (double element in queue)
            {
                if (element != 0)
                {
                    Console.Write(element + " ");
                    neshto = true;
                }
            }
            if (!neshto)
            {
                Console.WriteLine("Nqma");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
    

