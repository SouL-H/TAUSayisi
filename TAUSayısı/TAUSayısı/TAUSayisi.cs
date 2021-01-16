using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAUSayısı
{
    class TAUSayisi
    {
        public void TAUSayi(int sayi)
        {
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("*******************************                    1 - " + sayi + " arasındaki                 *********************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("************************* @@@@@@@  @@@@@@  @@@  @@@       @@@@@@  @@@@@@  @@@ @@@ @@@  @@@@@@ @@@ *********************");
            Console.WriteLine("*************************   @@!   @@!  @@@ @@!  @@@      !@@     @@!  @@@ @@! !@@ @@! !@@     @@! *********************");
            Console.WriteLine("*************************   @!!   @!@!@!@! @!@  !@!       !@@!!  @!@!@!@!  !@!@!  !!@  !@@!!  !!@ *********************");
            Console.WriteLine("*************************   !!:   !!:  !!! !!:  !!!          !:! !!:  !!!   !!:   !!:     !:! !!: *********************");
            Console.WriteLine("*************************    :     :   : :  :.:: :       ::.: :   :   : :   .:    :   ::.: :  :   *********************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("\n");
            int counter = 0;
            int divisorCounter;

            for (int i = 1; i < sayi; i++)
            {
                divisorCounter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorCounter++;
                    }
                }
                if (i % divisorCounter == 0)
                {
                    Console.Write(i + "    ");
                    counter++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nToplamda " + counter + " tane Tau sayısı vardır.");
            Console.Read();
        }
    }
}
