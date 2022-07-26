// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
namespace Seminar9
{
    class Program
    {
        public static int Ackermann(int m, int n)
        {
            return m == 0 ? n + 1 : n == 0 ? Ackermann(m - 1, 1) : Ackermann(m - 1, Ackermann(m, n - 1));
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите значения m и n.");
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"A(m, n) = {Ackermann(m, n)}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}