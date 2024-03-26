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
            int contage = 0;
            
            
            while (contage >= 0 && contage < 101) 
            {
                
                Console.WriteLine(contage);
                contage++;
            }
          
            Console.ReadKey();

        }
    }
}
