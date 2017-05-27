using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    class Slide5
    {
        public void ArrayMult()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 6;
                Console.WriteLine(array[i]);
            }
        }

        public void HighterSeq()
        {
            Console.WriteLine("Digite o número de posições que tem o array");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                int[,] seq = new int[n, n];
                int countI = 0;
                int countJ = 0;
                int highterI = 0;
                int highterJ = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Digite o " + (i + 1) + " número do array");
                    array[i] = int.Parse(Console.ReadLine());

                    if (i != 0)
                    {
                        if (array[i] == array[i - 1] + 1)
                        {
                            countJ++;
                        }
                        else
                        {
                            if (highterJ < countJ)
                            {
                                highterI = countI;
                            }
                            countI++;
                            countJ = 0;
                        }
                    }

                    seq[countI, countJ] = array[i];
                }

                Console.WriteLine("Maior sequência contida no array");
                for (int j = 0; j < array.Length; j++)
                {
                    if (seq[highterI, j] != 0)
                    {
                        Console.Write(seq[highterI, j] + " ");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void HighterNumber()
        {
            Console.WriteLine("Digite o número de posições que tem o array");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Digite o " + (i + 1) + " número do array");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int aux = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            aux = array[i];
                            array[i] = array[j];
                            array[j] = aux;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void IndexChar()
        {
        }
    }
}
