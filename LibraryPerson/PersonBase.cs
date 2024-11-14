using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryPerson
{
    //TODO +: RSDN
    /// <summary>
    /// Класс PersonBase
    /// </summary>
    public abstract class PersonBase
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
        /// Минимальный возраст
        /// </summary>
        public virtual int MinAge { get; } = 0;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public virtual int MaxAge { get; } = 150;

        /// <summary>
        /// Пол
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Имя
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
        /// Фамилия
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
        /// Возраст
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
        /// Пол
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
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        //public PersonBase() : this("Фамилия", "Имя", 19, Gender.Female)
        //{
        //}

        //TODO +: remove
        public PersonBase() { }
        /// <summary>
        /// Получение информации о человеке
        /// </summary>
        /// <returns>Информация о человеке</returns>
        public string GetPersonInfo() =>
            $"{Name} {Surname}; Age: {Age}; Gender: {Gender}";

        /// <summary>
        /// Получение имени и фамилии
        /// </summary>
        /// <returns>Имя и фамилия</returns>
        public string GetNameSurname() => $"{Name} {Surname}";

        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="age">Возраст.</param>
        /// <returns>Возраст.</returns>
        /// <exception cref="Exception">Некорректный возраст.</exception>
        protected virtual int CheckAge(int age)
        {
            if (age < MinAge || age > MaxAge)
            {
                throw new IndexOutOfRangeException
                    ($"\nВозраст может быть в диапазоне от {MinAge} до {MaxAge} лет");
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
        /// Вывод информации о человеке
        /// </summary>
        public abstract string GetInfo();

        //TODO +: XML
        /// <summary>
        /// Проверка значения
        /// </summary>
        /// <param name="value">Информация о человеке</param>
        /// <returns>Информация о человеке</returns>
        /// <exception cref="ArgumentException">Пустая строка</exception>
        protected string CheckValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                //TODO +: refactor
                throw new ArgumentException
                    ("\nЗначение не должно быть пустым");
            }
            else
            {
                return value;
            }
        }
    }
}