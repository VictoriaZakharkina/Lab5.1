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
    public class Child : Person
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
        protected override int MinAge { get; } = _minAge;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        protected override int MaxAge { get; } = _maxAge;

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

        /// <summary>
        /// Get, set Мать
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

        /// <summary>
        /// Get, set Отец
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

        /// <summary>
        /// Get, set Учебное заведение
        /// </summary>
        public string School
        {
            get => _school;

            set => _school = CheckValue(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent">Отец/Мать</param>
        /// <param name="gender">Мужской/Женский</param>
        /// <exception cref="ArgumentException">Некорректный пол</exception>
        private void CheckParentGender(Adult parent, Gender gender)
        {
            if (parent != null && parent.Gender != gender)
            {
                throw new ArgumentException("Измените возраст родителя!");
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
        /// Ввод случайного ребенка
        /// </summary>
        /// <returns>Случайный ребенок</returns>
        public static Child GetRandomPerson()
        {
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
            string[] schoolNames = new string[]
            {
                "Гриффиндор", "Слизерин", "Когтевран",
                "Пуффендуй", "Школа #34", "Лицей #1"
            };

            var random = new Random();
            string name = string.Empty;
            string surname = string.Empty;
            var gender = (Gender)random.Next(0, 2);
            var language = (Language)random.Next(0, 2); 
            switch (gender)
            {
                case Gender.Male:
                    switch (language)
                    {
                        case Language.English:
                            name = maleNamesEng[random.Next(maleNamesEng.Length)];
                            surname = SurnamesEng[random.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = maleNamesRus[random.Next(maleNamesRus.Length)];
                            surname = maleSurnamesRus[random.Next(maleSurnamesRus.Length)];
                            break;
                    }
                    break;

                case Gender.Female:
                    switch (language)
                    {
                        case Language.English:
                            name = femaleNamesEng[random.Next(femaleNamesEng.Length)];
                            surname = SurnamesEng[random.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = femaleNamesRus[random.Next(femaleNamesRus.Length)];
                            surname = femaleSurnamesRus[random.Next(femaleSurnamesRus.Length)];
                            break;
                    }
                    break;
            }
            int age = random.Next(_minAge, _maxAge);

            string school = schoolNames[random.Next(schoolNames.Length)];

            Adult mother = GetRandomParent(1);
            Adult father = GetRandomParent(0);

            return new Child(name, surname, age, gender,
                            mother, father, school);
        }

        /// <summary>
        /// Создание случайного родителя для ребенка
        /// </summary>
        /// <param name="numberParent">Мать 1/Отец 0</param>
        /// <returns>Random Parent.</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        private static Adult GetRandomParent(int numberParent)
        {
            var random = new Random();
            var parentStatus = random.Next(0, 2);

            if (parentStatus == 0)
            {
                return null;
            }
            else
            {
                switch (numberParent)
                {
                    case 0:
                        return Adult.GetRandomPerson(Gender.Male);
                    case 1:
                        return Adult.GetRandomPerson(Gender.Female);
                    default:
                        throw new ArgumentException
                            ("Число должно быть равно 0 или 1");
                }
            }
        }

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
                "Утиные истории", "Чип и Дейл спешат на помощь", "Лунтик",
                "Смешарики", "Феи"
            };
            var random = new Random();
            string model = favoriteCartoon[random.Next(favoriteCartoon.Length)];
            return model;
        }

        /// <summary>
        /// Неизвестный ребенок
        /// </summary>
        public Child()
        {
        }
    }
}
