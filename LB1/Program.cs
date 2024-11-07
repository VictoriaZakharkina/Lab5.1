using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LibraryPerson;

namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {
            var personList = new PersonList();
            var random = new Random();

            for (var i = 0; i < 7; i++)
            {
                Person randomPerson = random.Next(0, 2) == 0
                    ? Adult.GetRandomPerson()
                    : Child.GetRandomPerson();
                personList.AddPerson(randomPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("\nИнформация о людях:");
            PrintList(personList);

            _ = Console.ReadKey();

            var person = personList.SearchPersonByIndex(3);
            switch (person)
            {
                case Adult adult:
                    Console.WriteLine($"\n{adult.GetNameSurname()} " +
                        $"({adult.Age} лет) {adult.GetSmokingStatus()}");
                    break;
                case Child child:
                    Console.WriteLine($"\n{child.GetNameSurname()}" +
                        $"({child.Age} лет) любит мультсериал {child.GetFavoriteCartoon()}");
                    break;
                default:
                    break;
            }

            _ = Console.ReadKey();
        }
        /// <summary>
        /// Вывод информации о каждом человеке в списке.
        /// </summary>
        /// <param name="personList">Список людей.</param>
        /// <exception cref="NullReferenceException">
        /// Некорректно</exception>
        public static void PrintList(PersonList personList)
        {
            if (personList.Length == 0)
            {
                throw new NullReferenceException("Список пуст");
            }
            else
            {
                for (int i = 0; i < personList.Length; i++)
                {
                    var tmpPerson = personList.SearchPersonByIndex(i);
                    Console.WriteLine($"\n{tmpPerson.GetInfo()}");
                }
            }
        }
    }
}
