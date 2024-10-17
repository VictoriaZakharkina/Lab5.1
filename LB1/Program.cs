using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//TODO: убрать лишний проект из решения
//TODO: разделить модель и консольный ввод-вывод
//TODO: правило одна сущность - один файл
namespace ConsoleApp9
{
    /// <summary>
    /// Класс Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Get,set Имя
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                _ = CheckLanguage(value);
                _name = CorrectRegister(value);

                if (_name != null)
                {
                    CheckNameSurname();
                }
            }
        }
        /// <summary>
        /// Get,set Фамилия
        /// </summary>
        public string Surname
        {
            get => _surname;

            set
            {
                _ = CheckLanguage(value);
                _surname = CorrectRegister(value);

                if (_surname != null)
                {
                    CheckNameSurname();
                }

            }
        }
        /// <summary>
        /// Get,set Возраст
        /// </summary>
        public int Age
        {
            get => _age;

            set
            {
                _age = CheckAge(value);
            }
        }

        /// <summary>
        /// Get,set Пол
        /// </summary>
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Default person.
        /// </summary>
        public Person() { }
        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="age">Возраст.</param>
        /// <returns>Возраст.</returns>
        /// <exception cref="Exception">Некорректный возраст.</exception>
        private int CheckAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new IndexOutOfRangeException
                    ($"\nВозраст может быть в диапазоне от 0 до 150 лет");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Проверка языка
        /// </summary>
        /// <param name="value">Имя или фамилия.</param>
        /// <returns>Имя или фамилия.</returns>
        /// <exception cref="Exception">Вводимая строка некорректна.</exception>
        private static Language CheckLanguage(string value)
        {
            var regexRus = new Regex(@"(^[а-яА-Я\-]+$)");
            var regexEng = new Regex(@"(^[a-zA-Z\-]+$)");
            if (!string.IsNullOrEmpty(value))
            {
                if (regexRus.IsMatch(value))
                {
                    return Language.Russian;
                }
                else if (regexEng.IsMatch(value))
                {
                    return Language.English;
                }
                else
                {
                    throw new FormatException
                        ("\nПишите либо на русском, либо на английском языке");
                }
            }
            else
            {
                throw new ArgumentException
                    ("\nЗначение не может быть пустым");
            }

        }

        /// <summary>
        /// Проверка имени и фамилии
        /// </summary>
        /// <exception cref="FormatException">Вводимая строка некорректна.</exception>
        private void CheckNameSurname()
        {
            if ((!string.IsNullOrEmpty(Name))
                && (!string.IsNullOrEmpty(Surname)))
            {
                var nameLanguage = CheckLanguage(Name);
                var surnameLanguage = CheckLanguage(Surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new FormatException
                        ("\nИмя и фамилия должны быть на одном языке");
                }
            }
        }

        /// <summary>
        /// Коррекция регистра
        /// </summary>
        /// <param name="value">Имя или фамилия.</param>
        /// <returns>Откорректированная строка.</returns>
        private string CorrectRegister(string value)
        {
            var symbols = new[] { "-", " " };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    int indexOfSymbol = value.IndexOf(symbol);
                    return value.Substring(0, 1).ToUpper()
                        + value.Substring(1, indexOfSymbol - 1).ToLower()
                        + symbol
                        + value.Substring(indexOfSymbol + 1, 1).ToUpper()
                        + value.Substring(indexOfSymbol + 2).ToLower();
                }
            }

            return value.Substring(0, 1).ToUpper() +
                    value.Substring(1, value.Length - 1).ToLower();
        }
        /// <summary>
        /// Ввод случайного человека.
        /// </summary>
        /// <returns>Случайный человек.</returns>
        public static Person GetRandomPerson()
        {
            //TODO: разделить английские и русские имена/фамилии
            //TODO: определить правила, позволяющие такую генерацию персоны
            string[] maleNames = new string[]
            {
                "Oliver", "Jack", "Harry", "Jacob", "Oscar",
                "Михаил", "Андрей", "Олег", "Павел", "Юрий"
            };

            string[] femaleNames = new string[]
            {
                "Emma", "Olivia", "Sophia", "Isabella", "Charlotte",
                "Мария", "Майя", "Нина", "Вера", "Октябрина"
            };

            string[] maleSurnames = new string[]
            {
                "Adams", "Watson", "Cooper", "Jenkins", "Smith",
                "Попов", "Иванов", "Краснов", "Селин", "Калиновский"
            };
            string[] femaleSurnames = new string[]
            {
                "Adams", "Watson", "Cooper", "Jenkins", "Smith",
                "Попова", "Иванова", "Краснова", "Селина", "Калиновская"
            };

            var random = new Random();
            string name;
            string surname;
            var gender = (Gender)random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    surname = maleSurnames[random.Next(maleSurnames.Length)];
                    break;
                case Gender.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    surname = femaleSurnames[random.Next(femaleSurnames.Length)];
                    break;
                default:
                    return new Person("Default", "Person", 0, Gender.Male);
            }

            int age = random.Next(0, 150);

            return new Person(name, surname, age, gender);
        }
        /// <summary>
        /// Получение вывода информации
        /// </summary>
        public string Info => $"{Name} {Surname}," +
            $" Age: {Age}, Gender: {Gender}";
    }

    //TODO: XML
    public enum Gender
    {
        /// <summary>
        /// Мужской пол
        /// </summary>
        Male,

        /// <summary>
        /// Женский пол
        /// </summary>
        Female
    }

    //TODO: XML
    public enum Language
    {
        /// <summary>
        /// Русский язык
        /// </summary>
        Russian,

        /// <summary>
        /// Английский язык
        /// </summary>
        English
    }

    /// <summary>
    /// Класс списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Создание массива из людей
        /// </summary>
        private Person[] _personList = new Person[0];

        /// <summary>
        /// Добавление человека в конец списка
        /// </summary>
        /// <param name="person">Человек.</param>
        public void AddPerson(Person person)
        {
            Array.Resize(ref _personList, _personList.Length + 1);
            _personList[_personList.Length - 1] = person;
        }

        /// <summary>
        /// Добавление нескольких человек.
        /// </summary>
        /// <param name="persons">Массив людей.</param>
        public void AddPersons(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }

        /// <summary>
        /// Получение индекса человека в списке
        /// </summary>
        /// <param name="person">Человек.</param>
        /// <returns>Индекс человека.</returns>
        /// <exception cref="Exception">Человек не существует.</exception>
        public int GetIndexPerson(Person person)
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
        public void DeletePersonByName(Person person)
        {
            RemovePersonByIndex(GetIndexPerson(person));
        }

        /// <summary>
        /// Поиск по индексу
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        /// <returns>Человек.</returns>
        public Person SearchPersonByIndex(int index)
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

    //TODO: XML
    internal class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {

            var inputPerson = InputPersonByConsole();
            var personList3 = new PersonList();
            personList3.AddPerson(inputPerson);
            Console.WriteLine("\nНовый человек");
            Info(personList3);
            _ = Console.ReadKey();
            Console.WriteLine("");

            var personList1 = new PersonList();
            var personList2 = new PersonList();

            Person[] personArr1 = new Person[]
            {
                new Person("William", "Lloyd", 45, Gender.Male),
                new Person("Петр", "Васильев", 37, Gender.Male),
                new Person("Анна", "Васильева", 21, Gender.Female)
            };

            Person[] personArr2 = new Person[]
            {
                new Person("Hector", "Elliott", 25, Gender.Male),
                new Person("Родион", "Соболев", 60, Gender.Male),
                new Person("Вера", "Иванова", 19, Gender.Female)
            };

            personList1.AddPersons(personArr1);
            personList2.AddPersons(personArr2);
            Console.WriteLine("Создано два списка:");
            PrintList(personList1, personList2);

            personList1.AddPerson(
                new Person("James", "Franco", 33, Gender.Male));
            Console.WriteLine("Добавлен новый человек в список 1");
            PrintList(personList1, personList2);

            personList2.AddPerson(personList1.SearchPersonByIndex(1));
            Console.WriteLine("Добавлен человек из списка 1 в список 2");
            PrintList(personList1, personList2);

            personList1.RemovePersonByIndex(1);
            Console.WriteLine("Второй человек удален из 1 списка");
            PrintList(personList1, personList2);

            personList2.ClearPersonList();
            Console.WriteLine("Второй список очищен");
            PrintList(personList1, personList2);

            personList1.AddPerson(Person.GetRandomPerson());
            Console.WriteLine("Добавлен случайный человек в список 1");
            PrintList(personList1, personList2);

        }

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
        private static void ActionHandler
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
