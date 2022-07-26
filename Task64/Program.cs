// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
namespace Seminar9
{
    class Program
    {
        public static void NatNumPrint(int firstNum, int lastNum)
        {
            if (firstNum <= lastNum)
            {
                for (int i = firstNum; i <= lastNum; i++)
                {
                    Console.Write($"{i},  ");
                }
            }
            else
            {
                for (int i = firstNum; i >= lastNum; i--)
                {
                    Console.Write($"{i}  ");
                }
            }

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
            NatNumPrint(m, n);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}