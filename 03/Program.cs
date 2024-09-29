using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (true)
            {
                Console.Write("Введите число (или пустую строку для завершения): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    AddNumberToSet(uniqueNumbers, number);
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
        }

        /// <summary>
        /// Метод для добавления числа в HashSet.
        /// Если число успешно добавлено, выводится сообщение о сохранении.
        /// Если число уже присутствует, выводится сообщение о наличии числа в коллекции.
        /// </summary>
        /// <param name="numbers">HashSet для хранения уникальных чисел.</param>
        /// <param name="number">Число, которое нужно добавить.</param>
        static void AddNumberToSet(HashSet<int> numbers, int number)
        {
            if (numbers.Add(number))
            {
                Console.WriteLine($"Число {number} успешно сохранено.");
            }
            else
            {
                Console.WriteLine($"Число {number} уже вводилось ранее.");
            }
        }
    }
}
