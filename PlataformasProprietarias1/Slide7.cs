using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }

        public static int Soma(this IEnumerable<int> ie)
        {
            int sum = 0;
            foreach (int number in ie)
            {
                sum += number;
            }
            return sum;
        }

        public static int Produto(this IEnumerable<int> ie)
        {
            int mult = 1;
            foreach(int number in ie)
            {
                mult *= number;
            }
            return mult;
        }

        public static int Minimo(this IEnumerable<int> ie)
        {
            int? min = null;
            foreach (int number in ie)
            {
                if (min == null || number < min)
                    min = number;
            }
            return (int)min;
        }

        public static int Maximo(this IEnumerable<int> ie)
        {
            int? max = null;
            foreach (int number in ie)
            {
                if (max == null || number > max)
                    max = number;
            }
            return (int)max;
        }

        public static double Media(this IEnumerable<int> ie)
        {
            double sum = 0;
            double count = 0;
            foreach (int number in ie)
            {
                count++;
                sum += number;
            }
            return sum/count;
        }

        public static string Capitalize(this string str)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(str.ToLower());
        }
    }

    class Slide7
    {
        public class Student
        {
            public Student(string firstname, string lastname)
            {
                this.Firstname = firstname;
                this.Lastname = lastname;
            }

            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }

        public void FakeSubstring()
        {
            StringBuilder example = new StringBuilder("My name is Bond, James Bond");
            Console.WriteLine(example.Substring(17, 10));
        }

        public void EnumerableFunctions()
        {
            IEnumerable<int> ie = new int[] { 2, 4, 1, 7};
            StringBuilder value = new StringBuilder("[");
            foreach(int number in ie)
            {
                value.Append(number + ", ");
            }
            Console.WriteLine("Valores: " + value.Remove(value.Length - 2, 2).Append("]"));
            Console.WriteLine("Soma dos valores: " + ie.Soma());
            Console.WriteLine("Produto dos valores: " + ie.Produto());
            Console.WriteLine("Menor valor: " + ie.Minimo());
            Console.WriteLine("Maior valor: " + ie.Maximo());
            Console.WriteLine("Média dos valores: " + ie.Media());
        }

        public void OrderByThenBy()
        {
            List<Student> students = new List<Student> {
                new Student("Yami", "Yugi"),
                new Student("Seto", "Kaiba"),
                new Student("Joey", "Wheeler"),
                new Student("Mai", "Valentine"),
                new Student("Téa", "Gardner"),
                new Student("Weevil", "Underwood"),
                new Student("Rex", "Raptor"),
                new Student("Mako", "Tsunami"),
                new Student("Yami", "Bakura"),
                new Student("Bandit", "Keith"),
                new Student("Ishizu", "Ishtar"),
                new Student("Odion", ""),
                new Student("Maximillion", "Pegasus"),
                new Student("Irmãos", "Paradoxo")
            };

            students = students.OrderBy(student => student.Firstname)
                .ThenBy(student => student.Lastname)
                .ToList();

            Console.WriteLine("Estudantes ordenados:");
            foreach(Student student in students)
            {
                Console.WriteLine(student.Firstname + " " + student.Lastname);
            }
        }

        public void FakeCapitalize()
        {
            string music = "Você É luz, é RAIO esTrela e LuAr.";
            Console.WriteLine(music.Capitalize());
        }
    }
}
