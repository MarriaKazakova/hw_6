/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int[] lst = Array.ConvertAll(numbers, int.Parse);

        myFunc(lst);
    }

    static void myFunc(int[] lst)
    {
        int cnt_i = 0;
        foreach (int i in lst)
        {
            if (typeof(int) != i.GetType())
            {
                Console.WriteLine("В массиве должны быть числа");
                return;
            }
            else if (Math.Abs(i) < 100)
            {
                Console.WriteLine("Пожалуйста, введите трехзначные числа");
                return;
            }
            else if (Math.Abs(i) > 999)
            {
                Console.WriteLine("Пожалуйста, введите трехзначные числа");
                return;
            }
            else
            {
                if (i % 2 == 0)
                {
                    cnt_i += 1;
                }
            }
        }
        Console.WriteLine("Количество четных чисел в массиве: " + cnt_i);
    }
}
