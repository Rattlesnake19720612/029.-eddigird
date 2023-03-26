using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029.eddigird
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int eddigird = 1;
            

            while (eddigird < szam)
            //for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(eddigird);
                eddigird++;
            }
    
            Console.ReadKey();

        }
        
        
    }
}
