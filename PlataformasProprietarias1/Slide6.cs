using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    class Slide6
    {
        public void TryCatchFinally()
        {
            Console.WriteLine("Digite 1 número para calcular a raiz quadrada");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(n));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Número inválido");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        public void MultCatch()
        {
            Console.WriteLine("Digite 2 números para a divisão");

            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(n1) / int.Parse(n2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro na conversão dos números");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Erro na divisão dos números");
            }
        }
    }
}
