using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    class Slide4
    {
        public void NotDivisible3And7()
        {
            Console.WriteLine("Digite 1 número inteiro maior que 1");

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 2)
                {
                    Console.WriteLine("Entrada não é válida");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 3 != 0 || i % 7 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void HigherAndSmaller()
        {
            Console.WriteLine("Digite quantos números inteiros quiser e qualquer outra coisa pra parar");

            int? higher = null;
            int? smaller = null;

            try
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (higher == null || n > higher)
                    {
                        higher = n;
                    }
                    if (smaller == null || n < smaller)
                    {
                        smaller = n;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Maior número: " + ((higher == null) ? "não tem" : higher.ToString()));
                Console.WriteLine("Menor número: " + ((smaller == null) ? "não tem" : smaller.ToString()));
            }
        }

        public void Fibonacci()
        {
            Console.WriteLine("Digite 1 número inteiro maior que 0");

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 1)
                {
                    Console.WriteLine("Entrada não é válida");
                }
                else
                {
                    int sum = 0;
                    int previous = 0;
                    int current = 1;
                    int aux = 0;

                    for (int i = 1; i < n; i++)
                    {
                        sum += current;
                        aux = current;
                        current += previous;
                        previous = aux;
                    }

                    Console.WriteLine("Soma do(s) " + n + " primeiro(s) número(s) da sequencia Fibonacci: " + sum);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void Matrix()
        {
            Console.WriteLine("Digite 1 número inteiro no intervalo de 1 à 20");

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 20)
                {
                    Console.WriteLine("Entrada não é válida");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = i; j < n + i; j++)
                        {
                            Console.Write(((j < 10) ? "  " : " ") + j);
                        }
                        Console.WriteLine();
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
