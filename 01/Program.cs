using System;
using System.Collections.Generic;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            FillList(numbers, 100);

            Console.WriteLine("Коллекция чисел до удаления:");
            PrintList(numbers);

            RemoveNumbersInRange(numbers, 25, 50);

            Console.WriteLine("\nКоллекция чисел после удаления:");
            PrintList(numbers);
        }

        #region Методы

        // <summary>
        // Метод для заполнения списка случайными числами
        // </summary>
        // <param name="list">Список целых чисел для заполнения</param>
        // <param name="size">Размер списка</param>
        static void FillList(List<int> list, int size)
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(0, size + 1));
            }
        }

        // <summary>
        // Метод для удаления чисел в указанном диапазоне
        // </summary>
        // <param name="list">Список целых чисел для удаления</param>
        // <param name="minValue">Минимальное значение диапазона</param>
        // <param name="maxValue">Максимальное значение диапазона</param>
        static void RemoveNumbersInRange(List<int> list, int minValue, int maxValue)
        {
            list.RemoveAll(num => num > minValue && num < maxValue);
        }

        // <summary>
        // Метод для вывода списка на экран
        // </summary>
        // <param name="list">Список целых чисел для вывода</param>
        static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); Console.ReadKey();
        }

        #endregion
    }
}
