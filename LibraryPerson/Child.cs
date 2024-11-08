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

        //TODO: XML
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

        //TODO: XML
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

        //TODO: XML
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

        //TODO: RSDN
        /// <summary>
        /// Генератор случайных параметров
        /// </summary>
        private static Random rnd = new Random();

        //TODO: extract
        /// <summary>
        /// Ввод случайного ребенка
        /// </summary>
        /// <returns>Случайный ребенок</returns>
        public static Child GetRandomPerson()
        {
            //TODO: duplication
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
            //TODO: RSDN
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

            // var randomInfomationDictionaries =
            //     new Dictionary<Gender, Dictionary<Language, List<string[]>>>()
            //     {
            //         { Gender.Male, new Dictionary<Language, List<string[]>>()
            //         {
            //             {
            //                 Language.English,
            //                 new List<string[]> ()
            //                 {
            //                     maleNamesEng, SurnamesEng
            //                 }
            //             },
            //             {
            //                 Language.Russian,
            //                 new List<string[]> ()
            //                 {
            //                     maleNamesRus, maleSurnamesRus
            //                 }
            //             }
            //         }
            //         },
            //         {
            //             Gender.Female, new Dictionary<Language, List<string[]>>()
            //             {
            //                 {
            //                     Language.English,
            //                     new List<string[]> ()
            //                     {
            //                         femaleNamesEng, SurnamesEng
            //                     }
            //                 },
            //                 {
            //                     Language.Russian,
            //                     new List<string[]> ()
            //                     {
            //                         femaleNamesRus, femaleSurnamesRus
            //                     }
            //                 }
            //             }
            //         }
            //     };
            // 
            // 
            // var gender = (Gender)rnd.Next(0, 2);
            // var language = (Language)rnd.Next(0, 2);
            // 
            // var nameSurnameList = randomInfomationDictionaries[gender][language];
            // string name = nameSurnameList[0][rnd.Next(nameSurnameList[0].Length)];
            // string surname = nameSurnameList[1][rnd.Next(nameSurnameList[1].Length)];

            string name = string.Empty;
            string surname = string.Empty;
            var gender = (Gender)rnd.Next(0, 2);
            var language = (Language)rnd.Next(0, 2); 
            switch (gender)
            {
                case Gender.Male:
                    switch (language)
                    {
                        case Language.English:
                            name = maleNamesEng[rnd.Next(maleNamesEng.Length)];
                            surname = SurnamesEng[rnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = maleNamesRus[rnd.Next(maleNamesRus.Length)];
                            surname = maleSurnamesRus[rnd.Next(maleSurnamesRus.Length)];
                            break;
                    }
                    break;

                case Gender.Female:
                    switch (language)
                    {
                        case Language.English:
                            name = femaleNamesEng[rnd.Next(femaleNamesEng.Length)];
                            surname = SurnamesEng[rnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            name = femaleNamesRus[rnd.Next(femaleNamesRus.Length)];
                            surname = femaleSurnamesRus[rnd.Next(femaleSurnamesRus.Length)];
                            break;
                    }
                    break;
            }
            int age = rnd.Next(_minAge, _maxAge);

            string school = schoolNames[rnd.Next(schoolNames.Length)];

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
            var parentStatus = rnd.Next(0, 2);

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
                "Утиные истории", 
                "Чип и Дейл спешат на помощь", 
                "Лунтик",
                "Смешарики", "Феи"
            };
            string cartoon = favoriteCartoon[rnd.Next(favoriteCartoon.Length)];
            return cartoon;
        }

        //TODO: remove
        /// <summary>
        /// Неизвестный ребенок
        /// </summary>
        public Child()
        {
        }
    }
}
