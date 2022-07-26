// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
namespace Seminar9
{
    class Program
    {
        public static int NatNumSum (int m, int n)
        {
            return m==n ? m : NatNumSum(m, n-1)+ n;
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите значения чисел");
            Console.Write("M = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (m<=n) Console.WriteLine($"Сумма чисел от {m} до {n} = " + NatNumSum(m, n));
            else Console.WriteLine($"Сумма чисел от {n} до {m} = " + NatNumSum(n, m));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}