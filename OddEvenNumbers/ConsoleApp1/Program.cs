namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("Numbers", a);
            PrintNumbers("Even", a.Where(n => IsEven(n)));
            PrintNumbers("Odd", a.Where(n => IsOdd(n)));

            Console.ReadKey();
        }
        static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (var n in numbers)
            {
                Console.Write($" {n}");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int n) => n % 2 == 0;
        static bool IsOdd(int n) => !IsEven(n);
    }
}
