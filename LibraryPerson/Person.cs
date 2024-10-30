using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryPerson
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
        private static Random personRnd = new Random();
        /// <summary>
        /// Ввод случайного человека.
        /// </summary>
        /// <returns>Случайный человек.</returns>
        public static Person GetRandomPerson()
        {

            //TODO +: разделить английские и русские имена/фамилии
            //TODO +: определить правила, позволяющие такую генерацию персоны
            string[] maleNamesRus = new string[]
            {
                "Михаил", "Андрей", "Олег", "Павел", "Юрий"
            };
            string[] maleNamesEng = new string[]
            {
                "Oliver", "Jack", "Harry", "Jacob", "Oscar"
            };
            string[] femaleNamesRus = new string[]
            {
                "Мария", "Майя", "Нина", "Вера", "Октябрина"
            };
            string[] femaleNamesEng = new string[]
            {
                "Emma", "Olivia", "Sophia", "Isabella", "Charlotte"
            };
            string[] maleSurnamesRus = new string[]
            {
                "Попов", "Иванов", "Краснов", "Селин", "Калиновский"
            };
            string[] SurnamesEng = new string[]
            {
                "Adams", "Watson", "Cooper", "Jenkins", "Smith"
            };
            string[] femaleSurnamesRus = new string[]
            {
                "Попова", "Иванова", "Краснова", "Селина", "Калиновская"
            };

            var random = new Random();
            string name;
            string surname;
            var gender = (Gender)personRnd.Next(0, 2);
            var language = (Language)personRnd.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    switch (language)
                    {
                        case Language.English:
                            name = maleNamesEng[personRnd.Next(maleNamesEng.Length)];
                            surname = SurnamesEng[personRnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = maleNamesRus[personRnd.Next(maleNamesRus.Length)];
                            surname = maleSurnamesRus[personRnd.Next(maleSurnamesRus.Length)];
                            break;
                        default:
                            return new Person("Default", "Person", 0, Gender.Male);
                    }
                    break;

                case Gender.Female:
                    switch (language)
                    {
                        case Language.English:
                            name = femaleNamesEng[personRnd.Next(femaleNamesEng.Length)];
                            surname = SurnamesEng[personRnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = femaleNamesRus[personRnd.Next(femaleNamesRus.Length)];
                            surname = femaleSurnamesRus[personRnd.Next(femaleSurnamesRus.Length)];
                            break;
                        default:
                            return new Person("Default", "Person", 0, Gender.Female);
                    }
                    break;
                default:
                    return new Person("Default", "Person", 0, Gender.Male);
            }

            int age = personRnd.Next(0, 150);

            return new Person(name, surname, age, gender);
        }
        /// <summary>
        /// Получение вывода информации
        /// </summary>
        public string Info => $"{Name} {Surname}," +
            $" Age: {Age}, Gender: {Gender}";
    }
}
