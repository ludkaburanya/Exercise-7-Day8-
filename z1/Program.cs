using System.Text.RegularExpressions;

namespace z1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");

            string pattern = @"[^\sаяуюоеёэиы]{3}";
            string input = Console.ReadLine();

            RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;

            Console.WriteLine("Найдены три согласные буквы:");
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}