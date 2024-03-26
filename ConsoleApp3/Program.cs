using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contage = 0;

            while (contage >= 0 && contage < 100)
            {
                contage += 2;
                Console.WriteLine(contage);
                
            }
               Console.ReadKey();
        }
    }
}
