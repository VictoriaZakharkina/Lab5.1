using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
    /// <summary>
    /// Класс Child
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Минимальный возраст
        /// </summary>
        private const int _minAge = 0;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        private const int _maxAge = 17;

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public override int MinAge { get; } = _minAge;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public override int MaxAge { get; } = _maxAge;

        /// <summary>
        /// Мать ребенка
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Отец ребенка
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Учебное заведение
        /// </summary>
        private string _school;

        //TODO +: XML
        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother
        {
            get => _mother;

            set
            {
                CheckParentGender(value, Gender.Female);
                _mother = value;
            }
        }

        //TODO +: XML
        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father
        {
            get => _father;

            set
            {
                CheckParentGender(value, Gender.Male);
                _father = value;
            }
        }

        //TODO +: XML
        /// <summary>
        /// Учебное заведение
        /// </summary>
        public string School
        {
            get => _school;

            set => _school = CheckValue(value);
        }

        /// <summary>
        /// Проверка пола
        /// </summary>
        /// <param name="parent">Отец/Мать</param>
        /// <param name="gender">Мужской/Женский</param>
        /// <exception cref="ArgumentException">Некорректный пол</exception>
        private void CheckParentGender(Adult parent, Gender gender)
        {
            if (parent != null && parent.Gender != gender)
            {
                throw new ArgumentException("Измените пол родителя!");
            }
        }

        /// <summary>
        /// Информация о ребенке
        /// </summary>
        /// <returns>Информация</returns>
        public override string GetInfo()
        {
            string motherStatus = "Нет матери";
            string fatherStatus = "Нет отца";

            if (Mother != null)
            {
                motherStatus = $"Мать - {Mother.GetNameSurname()}";
            }

            if (Father != null)
            {
                fatherStatus = $"Отец - {Father.GetNameSurname()}";
            }

            string schoolStatus = "Не учится";
            if (!string.IsNullOrEmpty(School))
            {
                schoolStatus = $"Учится в {School}";
            }

            if (Mother == null && Father == null)
            {
                return $"{GetPersonInfo()} \n{schoolStatus}" +
                        $"\nК сожалению, данный ребенок - сирота";
            }
            else
            {
                return $"{GetPersonInfo()}\n" +
                    $"{fatherStatus},\n" +
                    $"{motherStatus},\n" +
                    $"{schoolStatus}";
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="mother">Мать</param>
        /// <param name="father">Отец</param>
        /// <param name="school">Учебное заведение</param>
        public Child(string name, string surname, int age, Gender gender,
            Adult mother, Adult father, string school)
            : base(name, surname, age, gender)
        {
            Mother = mother;
            Father = father;
            School = school;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Child() : this("Name", "Surname", 10, Gender.Male,
            null, null, "School")
        { }

        //TODO +: RSDN
        /// <summary>
        /// Генератор случайных параметров
        /// </summary>
        private static Random _random = new Random();

        //TODO +: extract

            //TODO +: duplication


        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <returns>Корректный возраст</returns>
        /// <exception cref="IndexOutOfRangeException">
        /// Некорректный возраст</exception>
        protected override int CheckAge(int age)
        {
            if (age < MinAge || age > MaxAge)
            {
                throw new IndexOutOfRangeException
                    ($"\nВозраст должен быть в промежутке " +
                    $"от {MinAge} до {MaxAge}");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Метод для ребенка
        /// </summary>
        /// <returns>Название мультсериала</returns>
        public string GetFavoriteCartoon()
        {
            string[] favoriteCartoon = new string[]
            {
                "Утиные истории", 
                "Чип и Дейл спешат на помощь", 
                "Лунтик",
                "Смешарики", "Феи"
            };
            string cartoon = favoriteCartoon[_random.Next(favoriteCartoon.Length)];
            return cartoon;
        }

        //TODO +: remove
    }
}
