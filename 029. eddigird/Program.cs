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

/*Ez a program egy egyszerű példa arra, hogy hogyan írható ki a konzolra az 1-től egy adott számig terjedő számsor. A program a felhasználótól bekér egy egész számot, majd egy ciklus segítségével kiírja az 1-től az adott számig terjedő számsort.

A while ciklus előnye a for ciklussal szemben, hogy általában kisebb kódmennyiséget igényel, és azonos hatékonysággal működik. Az i változó helyett itt az eddigird változó deklarálása és növelése történik a ciklusmagban.

Az alábbi program futásakor a felhasználó a konzolon megadhat egy egész számot, majd az Enter billentyűt kell lenyomnia. A program az adott számig kiírja a számsort, majd a végén a felhasználó a bármilyen billentyű lenyomásával bezárhatja a konzolt.

A program utolsó sorában a Console.ReadKey(); parancs található, amely arra szolgál, hogy a program ne záruljon be azonnal, hanem csak akkor, ha a felhasználó bármilyen billentyűt lenyom. Ez segíti a program felhasználóját, hogy láthassa a konzol kimenetét, mielőtt a program bezárulna.*/

