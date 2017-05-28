using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void MostFrequently()
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

                int? frequently = null;
                int times = 0;

                int? current = null;
                int count = 0;
                foreach (int number in array)
                {
                    if (current == null || current == number)
                    {
                        current = number;
                        count++;
                    } else
                    {
                        if (frequently == null || count > times)
                        {
                            frequently = current;
                            times = count;
                        }

                        current = number;
                        count = 1;
                    }
                }

                if (count > times)
                {
                    frequently = current;
                    times = count;
                }

                Console.WriteLine(frequently + "(" + times + " times)");

            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
            }
        }

        public void IndexChar()
        {
            Console.WriteLine("Digite uma palavra");
            string word = Console.ReadLine();
            word = word.ToUpper();
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'W', 'Z' };

            foreach (char letter in word.ToCharArray())
            {
                for(int i = 0;i < letters.Length;i++)
                {
                    if (letters[i] == letter)
                        Console.WriteLine(i);
                }
            }
        }

        public void CountWord()
        {
            Console.WriteLine("Digite uma frase");
            string words = Console.ReadLine();
            words = words.ToLower();
            Regex regex = new Regex("[^\\w\\s+]");
            words = regex.Replace(words, "");
        
            Dictionary<string, int> dictonary = new Dictionary<string, int>();

            foreach (string word in words.Split(' '))
            {
                if (!word.Equals(""))
                {
                    if (dictonary.ContainsKey(word))
                        dictonary[word] = dictonary[word] + 1;
                    else
                        dictonary.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in dictonary.OrderBy(key => key.Value))
            {
                Console.WriteLine(pair.Key + "->" + pair.Value);
            }
        }
    }
}
