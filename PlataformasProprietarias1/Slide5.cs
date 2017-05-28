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

        public void MatrixCrazy()
        {
            Console.WriteLine("Digite o tamanho da matriz");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[,] matrix1 = new int[n, n];
                int[,] matrix2 = new int[n, n];
                int[,] matrix3 = new int[n, n];

                int value = n*n;
                int column = 0, row = 0, columnAux = 0, rowAux = 0;
                for (int i = 0; i < n*n; i++)
                {
                    matrix1[row, column] = value;
                    value--;

                    if (column == rowAux)
                    {
                        if (columnAux < (n-1))
                            columnAux++;
                        else
                            rowAux++;
                        column = columnAux;
                        row = rowAux;
                    }
                    else
                    {
                        row++;
                        column--;
                    }
                }
                
                value = n * n;
                column = n-1;
                row = 0;
                columnAux = n-1;
                rowAux = 0;
                int aux = 0;
                for (int i = 0; i < n * n; i++)
                {
                    matrix2[row, column] = value;
                    value--;

                    if (row == aux)
                    {
                        if (rowAux < (n - 1))
                            rowAux++;
                        else
                        {
                            aux++;
                            columnAux--;
                        }
                        column = columnAux;
                        row = rowAux;
                    }
                    else
                    {
                        row--;
                        column--;
                    }
                }

                value = 1;
                row = 0;
                column = 0;
                string way = "down";
                int times = n;
                int time = 1;

                for (int i = 0; i < n * n; i++)
                {
                    matrix3[row, column] = value;
                    value++;

                    if (time < times)
                    {
                        time++;
                    } else
                    {
                        time = 2;
                        switch (way)
                        {
                            case "down":
                                way = "left";
                                break;
                            case "left":
                                way = "up";
                                break;
                            case "up":
                                way = "right";
                                break;
                            case "right":
                                way = "down";
                                break;
                        }
                    }

                    switch (way)
                    {
                        case "down":
                            row++;
                            break;
                        case "left":
                            column++;
                            break;
                        case "up":
                            row--;
                            break;
                        case "right":
                            column--;
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Matriz do item a:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Matriz do item b:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Matriz do item c:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada não é válida");
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
