using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            AddEntries(phoneBook);

            FindOwnerByPhoneNumber(phoneBook);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для ввода телефонных номеров и ФИО владельцев.
        /// Пользователь может вводить номера и ФИО до тех пор, пока не введет пустую строку.
        /// </summary>
        /// <param name="phoneBook">Телефонная книга, в которую будут добавлены записи.</param>
        static void AddEntries(Dictionary<string, string> phoneBook)
        {
            while (true)
            {
                Console.Write("\nВведите номер телефона (или пустую строку для завершения): ");
                string phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    break;
                }

                Console.Write("Введите ФИО владельца: ");
                string owner = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(owner))
                {
                    phoneBook[phoneNumber] = owner; // Добавляем или обновляем запись
                }

                PrintAllEntries(phoneBook);
            }
        }

        /// <summary>
        /// Метод для вывода всех записей в телефонной книге.
        /// Выводит номер телефона и ФИО владельца.
        /// </summary>
        /// <param name="phoneBook">Телефонная книга для вывода всех записей.</param>
        static void PrintAllEntries(Dictionary<string, string> phoneBook)
        {

            Console.WriteLine("\nВсе записи в телефонной книге:");
            if (phoneBook.Count == 0)
            {
                Console.WriteLine("Телефонная книга пуста.");
                return;
            }

            foreach (var entry in phoneBook)
            {
                Console.WriteLine($"Номер: {entry.Key}, Владелец: {entry.Value}");
            }
        }

        /// <summary>
        /// Метод для поиска владельца по введенному номеру телефона.
        /// Если номер найден в словаре, выводится ФИО владельца, в противном случае выводится сообщение об отсутствии владельца.
        /// </summary>
        /// <param name="phoneBook">Телефонная книга, по которой будет выполнен поиск.</param>
        static void FindOwnerByPhoneNumber(Dictionary<string, string> phoneBook)
        {
            Console.Write("\nВведите номер телефона для поиска владельца: ");
            string phoneNumber = Console.ReadLine();

            if (phoneBook.TryGetValue(phoneNumber, out string owner))
            {
                Console.WriteLine($"Владелец номера {phoneNumber}: {owner}");
            }
            else
            {
                Console.WriteLine("Владелец с таким номером телефона не найден.");
            }
        }
    }
}
