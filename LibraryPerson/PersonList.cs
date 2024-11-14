using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
    /// <summary>
    /// Класс списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Создание массива из людей
        /// </summary>
        private PersonBase[] _personList = new PersonBase[0];

        /// <summary>
        /// Добавление человека в конец списка
        /// </summary>
        /// <param name="person">Человек.</param>
        public void AddPerson(PersonBase person)
        {
            Array.Resize(ref _personList, _personList.Length + 1);
            _personList[_personList.Length - 1] = person;
        }

        /// <summary>
        /// Получение индекса человека в списке
        /// </summary>
        /// <param name="person">Человек.</param>
        /// <returns>Индекс человека.</returns>
        /// <exception cref="Exception">Человек не существует.</exception>
        public int GetIndexPerson(PersonBase person)
        {
            for (int index = 0; index < _personList.Length; index++)
            {
                if (person == _personList[index])
                {
                    return index;
                }
            }

            throw new Exception("Такой человек не существует");
        }

        /// <summary>
        /// Проверка индекса в массиве
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        /// <exception cref="IndexOutOfRangeException">
        /// Индекс не существует.</exception>
        public void IsIndexExist(int index)
        {
            if (index < 0 || index >= _personList.Length)
            {
                throw new IndexOutOfRangeException
                    ("Такой индекс не существует");
            }
        }

        /// <summary>
        /// Удаление по индексу
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        public void RemovePersonByIndex(int index)
        {
            IsIndexExist(index);

            _personList = _personList.
                Where((person, i) => i != index).ToArray();
        }

        /// <summary>
        /// Удаление без индекса
        /// </summary>
        /// <param name="person">Человек.</param>
        public void DeletePersonByName(PersonBase person)
        {
            RemovePersonByIndex(GetIndexPerson(person));
        }

        /// <summary>
        /// Поиск по индексу
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        /// <returns>Человек.</returns>
        public PersonBase SearchPersonByIndex(int index)
        {
            IsIndexExist(index);
            return _personList[index];
        }

        /// <summary>
        /// Получение количества элементов в списке
        /// </summary>
        public int Length => _personList.Length;

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void ClearPersonList()
        {
            Array.Resize(ref _personList, 0);
        }
    }
}
