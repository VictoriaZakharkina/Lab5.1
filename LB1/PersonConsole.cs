using LibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    //TODO: XML
    internal class PersonConsole
    {
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
