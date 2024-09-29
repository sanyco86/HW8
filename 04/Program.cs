using System;
using System.Xml.Linq;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();

            Console.Write("Введите название улицы: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            XElement contactXml = CreateXmlForContact(name, street, houseNumber, flatNumber, mobilePhone, flatPhone);

            SaveXmlToFile(contactXml, "contact.xml");

            Console.WriteLine("Данные успешно сохранены в файл contact.xml.");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для создания XML-документа с данными о контакте.
        /// </summary>
        /// <param name="name">ФИО человека.</param>
        /// <param name="street">Улица проживания.</param>
        /// <param name="houseNumber">Номер дома.</param>
        /// <param name="flatNumber">Номер квартиры.</param>
        /// <param name="mobilePhone">Мобильный телефон.</param>
        /// <param name="flatPhone">Домашний телефон.</param>
        /// <returns>XML элемент с информацией о человеке.</returns>
        static XElement CreateXmlForContact(string name, string street, string houseNumber, string flatNumber, string mobilePhone, string flatPhone)
        {
            // Формируем XML структуру
            XElement personElement = new XElement("Person", new XAttribute("name", name),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone)
                )
            );

            return personElement;
        }

        /// <summary>
        /// Метод для сохранения XML-документа в файл.
        /// </summary>
        /// <param name="xmlElement">XML элемент, который нужно сохранить в файл.</param>
        /// <param name="fileName">Имя файла, в который нужно сохранить XML.</param>
        static void SaveXmlToFile(XElement xmlElement, string fileName)
        {
            xmlElement.Save(fileName);
        }
    }
}
