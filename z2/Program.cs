using System.Text.RegularExpressions;

namespace z2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст:");

            string pattern = @"(\w{1})\1{1,1}";
            string input = Console.ReadLine();

            Console.WriteLine("Найденные подряд идущие одинаковые буквы:");
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }

}