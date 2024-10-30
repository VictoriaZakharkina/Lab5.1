using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LibraryPerson;

//TODO +: убрать лишний проект из решения
//TODO +: разделить модель и консольный ввод-вывод
//TODO +: правило одна сущность - один файл
namespace LB1
{
    //TODO +: XML
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

            var inputPerson = PersonConsole.InputPersonByConsole();
            var personList3 = new PersonList();
            personList3.AddPerson(inputPerson);
            Console.WriteLine("\nНовый человек");
            PersonConsole.Info(personList3);
            _ = Console.ReadKey();
            Console.WriteLine("");

            var personList1 = new PersonList();
            var personList2 = new PersonList();
            for (int i = 0; i<3; i++)
            {
                personList1.AddPerson(Person.GetRandomPerson());
                personList2.AddPerson(Person.GetRandomPerson());
            }

            Console.WriteLine("Создано два списка:");
            PersonConsole.PrintList(personList1, personList2);

            personList1.AddPerson(
                new Person("James", "Franco", 33, Gender.Male));
            Console.WriteLine("Добавлен новый человек в список 1");
            PersonConsole.PrintList(personList1, personList2);

            personList2.AddPerson(personList1.SearchPersonByIndex(1));
            Console.WriteLine("Добавлен человек из списка 1 в список 2");
            PersonConsole.PrintList(personList1, personList2);

            personList1.RemovePersonByIndex(1);
            Console.WriteLine("Второй человек удален из 1 списка");
            PersonConsole.PrintList(personList1, personList2);

            personList2.ClearPersonList();
            Console.WriteLine("Второй список очищен");
            PersonConsole.PrintList(personList1, personList2);

            personList1.AddPerson(Person.GetRandomPerson());
            Console.WriteLine("Добавлен случайный человек в список 1");
            PersonConsole.PrintList(personList1, personList2);

        }

    }
}
