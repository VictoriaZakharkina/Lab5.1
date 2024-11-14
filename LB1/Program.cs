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
        private static Random rnd = new Random();
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {
            var personList = new PersonList();
            PersonBase randomPerson;
            Gender gender = (Gender)rnd.Next(0, 2);
            for (var i = 0; i < 7; i++)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    randomPerson = RandomPersonGenerator.GetRandomAdult(gender);
                }
                else
                {
                    randomPerson = RandomPersonGenerator.GetRandomChild();
                }

                personList.AddPerson(randomPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("\nИнформация о людях:");
            PersonConsole.PrintList(personList);

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
    }
}
