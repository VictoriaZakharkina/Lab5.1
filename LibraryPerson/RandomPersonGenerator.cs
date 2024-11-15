using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryPerson
{
    /// <summary>
    /// Класс RandomPersonGenerator
    /// </summary>
    public class RandomPersonGenerator
    {
        /// <summary>
        /// Генератор случайных параметров
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного человека
        /// </summary>
        /// <returns>Случайный человек</returns>
        public static void GetRandomPerson(PersonBase person, Gender gender)
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
            string[] surnamesEng = new string[]
            {
                "Adams", "Watson", "Cooper", "Jenkins", "Smith"
            };
            string[] femaleSurnamesRus = new string[]
            {
                "Попова", "Иванова", "Краснова", "Селина", "Калиновская"
            };

            var language = (Language)_random.Next(0, 2);
            person.Gender = gender;
            var randomInfomationDictionaries =
                new Dictionary<Gender, Dictionary<Language, List<string[]>>>()
                {
                    { Gender.Male, new Dictionary<Language, List<string[]>>()
                    {
                        {
                            Language.English,
                            new List<string[]> ()
                            {
                                maleNamesEng, surnamesEng
                            }
                        },
                        {
                             Language.Russian,
                             new List<string[]> ()
                             {
                                 maleNamesRus, maleSurnamesRus
                             }
                        }
                    }
                    },
                    {
                         Gender.Female, new Dictionary<Language, List<string[]>>()
                         {
                             {
                                 Language.English,
                                 new List<string[]> ()
                                 {
                                     femaleNamesEng, surnamesEng
                                 }
                             },
                             {
                                 Language.Russian,
                                 new List<string[]> ()
                                 {
                                     femaleNamesRus, femaleSurnamesRus
                                 }
                             }
                         }
                    }
                };

            var nameSurnameList = randomInfomationDictionaries[gender][language];
            person.Name = nameSurnameList[0][_random.Next(nameSurnameList[0].Length)];
            person.Surname = nameSurnameList[1][_random.Next(nameSurnameList[1].Length)];
            person.Age = _random.Next(person.MinAge, person.MaxAge);

        }
        /// <summary>
        /// Установка данных для класса Adult
        /// </summary>
        /// <param name="adult">Объект класса Adult</param>
        public static void AdultRandom(Adult adult)
        {
            string[] companyNames = new string[]
            {
                "Пятерочка", "Газпром", "Сибур",
                "Томский политехнический университет", "Школа #34"
            };
            adult.PassportID = _random.Next(Adult._minPassportID, Adult._maxPassportID);
            adult.Company = companyNames[_random.Next(companyNames.Length)];
            
            int marriegeStatus = _random.Next(0, 2);
            if (marriegeStatus == 0)
            {
                var newGender = 
                    adult.Gender == Gender.Male
                    ? Gender.Female
                    : Gender.Male;
                adult.Partner = GetRandomAdult(newGender);                
            }
        }
        /// <summary>
        /// Получение случайного объекта класса Adult
        /// </summary>
        /// <param name="gender">Пол</param>
        /// <returns>Объект класса Adult</returns>
        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            GetRandomPerson(adult, gender);
            AdultRandom(adult);
            return adult;
        }

        /// <summary>
        /// Установка данных для класса Child
        /// </summary>
        /// <param name="child">Объект класса Child</param>
        public static void ChildRandom(Child child)
        {
            string[] schoolNames = new string[]
            {
                "Гриффиндор", "Слизерин", "Когтевран",
                "Пуффендуй", "Школа #34", "Лицей #1"
            };
            child.School = schoolNames[_random.Next(schoolNames.Length)];
            child.Father = GetRandomParent(0);
            child.Mother = GetRandomParent(1);
        }
        /// <summary>
        /// Создание случайного родителя для ребенка
        /// </summary>
        /// <param name="numberParent">Мать 1/Отец 0</param>
        /// <returns>Random Parent.</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        private static Adult GetRandomParent(int numberParent)
        {
            var parentStatus = _random.Next(0, 2);

            if (parentStatus == 0)
            {
                return null;
            }
            else
            {
                switch (numberParent)
                {
                    case 0:
                        return GetRandomAdult(Gender.Male);
                    case 1:
                        return GetRandomAdult(Gender.Female);
                    default:
                        throw new ArgumentException
                            ("Число должно быть равно 0 или 1");
                }
            }
        }
        /// <summary>
        /// Получение случайного объекта класса Child
        /// </summary>
        /// <param name="gender">Пол</param>
        /// <returns>Объект класса Child</returns>
        public static Child GetRandomChild(Gender gender)
        {
            Child child = new Child();
            GetRandomPerson(child, gender);
            ChildRandom(child);
            return child;
        }
    }
}


