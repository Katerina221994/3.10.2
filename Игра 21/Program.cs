using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Игра_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте, сколько у вас карт на руках?");
            int cards = int.Parse(Console.ReadLine());
            int summ = 0;
           

            for (int i = 0; i<cards; i++ )
            {
                Console.WriteLine("Ввидите номинал карты");
                string denomination = Console.ReadLine();

    
                switch (denomination)
                {
                    case "J":
                    case "K":
                    case "Q":
                    case "T": 
                        summ = summ + 10;
                        break;
                    default:
                       int number = int.Parse(denomination);
                        summ = summ + number;
                        break;

                }

            }
            Console.WriteLine("Сумма карт = " + summ) ;
            Console.ReadKey();
          
        }
    }
}
