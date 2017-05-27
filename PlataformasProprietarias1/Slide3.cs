using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    class Slide3
    {
        public void HighestValue()
        {
            Console.WriteLine("Digite 5 números inteiros");
            try
            {
                int value1 = int.Parse(Console.ReadLine());
                int value2 = int.Parse(Console.ReadLine());
                int value3 = int.Parse(Console.ReadLine());
                int value4 = int.Parse(Console.ReadLine());
                int value5 = int.Parse(Console.ReadLine());

                int result = value1;
                if (value2 > result)
                {
                    result = value2;
                }
                if (value3 > result)
                {
                    result = value3;
                }
                if (value4 > result)
                {
                    result = value4;
                }
                if (value5 > result)
                {
                    result = value5;
                }

                Console.WriteLine("Maior número: " + result);
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void IntevalSwitch()
        {
            Console.WriteLine("Digite 1 número inteiro no intervalo de 1 à 9");

            try
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 1 || x > 9)
                {
                    Console.WriteLine("Entrada não é válida");
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine(x * 10);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Console.WriteLine(x * 100);
                            break;
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine(x * 1000);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }

        }
    }
}
