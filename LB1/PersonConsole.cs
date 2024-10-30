using LibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    internal class PersonConsole
    {
        /// <summary>
        /// Вывод данных массива
        /// </summary>
        /// <param name="personList">Список людей.</param>
        public static void Info(PersonList personList)
        {
            for (int i = 0; i < personList.Length; i++)
            {
                Console.WriteLine(personList.SearchPersonByIndex(i).Info);
            }
        }

        /// <summary>
        /// Вывод списка на консоль
        /// </summary>
        /// <param name="personList1">PersonList1.</param>
        /// <param name="personList2">PersonList2.</param>
        public static void PrintList(PersonList personList1,
                                     PersonList personList2)
        {
            Console.WriteLine("List1");
            Info(personList1);
            Console.WriteLine("\nList2");
            Info(personList2);
            _ = Console.ReadKey();
            Console.WriteLine("");
        }

        /// <summary>
        /// Добавление через консоль
        /// </summary>
        /// <returns>Новый человек.</returns>
        /// <exception cref="IndexOutOfRangeException">Значение вне диапазона.</exception>
        public static Person InputPersonByConsole()
        {
            var person = new Person();

            var actionList = new List<(Action Action, string)>
            {
                (
                    () =>
                    {
                        person.Name = Console.ReadLine();
                    },
                    "Введите имя:"
                ),
                (
                    () =>
                    {
                        person.Surname = Console.ReadLine();
                    },
                    "Введите фамилию:"
                ),
                (
                    () =>
                    {
                        person.Age = Convert.ToInt32(Console.ReadLine());
                    },
                    "Введите возраст:"
                ),
                (
                    () =>
                    {
                    if (!int.TryParse(Console.ReadLine(), out int tmpGender))
                    {
                        throw new ArgumentException
                           ("Число может принимать значение 0 и 1");
                    }

                    if (tmpGender < 0 || tmpGender > 1)
                    {
                        throw new IndexOutOfRangeException
                            ("Число может принимать значение 0 и 1");
                    }

                    var realGender = tmpGender == 0
                        ? Gender.Male
                        : Gender.Female;
                    person.Gender = realGender;
                    },
                    "Введите пол (0 - Мужской, 1 - Женский):"
                ),

            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Action, action.Item2);
            }

            return person;
        }

        /// <summary>
        /// Обработка ввода данных с консоли
        /// </summary>
        /// <param name="action">Действие.</param>
        /// <param name="inputMessage">Сообщение.</param>
        public static void ActionHandler
            (Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Повторите ввод");
                }
            }
        }
    }
}
