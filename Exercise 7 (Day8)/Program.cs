using System.Text.RegularExpressions;

namespace z3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string pattern = @"\b([1-9]|[1-8][0-9]|9[0-9])\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Найденные числа:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadKey();
        }
    }
}