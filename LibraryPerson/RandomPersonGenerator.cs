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

        //TODO: extract
        /// <summary>
        /// Ввод случайного взрослого
        /// </summary>
        /// <returns>Случайный взрослый</returns>
        public static void GetRandomPerson(PersonBase person)
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
            string[] surnamesEng = new string[]
            {
                "Adams", "Watson", "Cooper", "Jenkins", "Smith"
            };
            string[] femaleSurnamesRus = new string[]
            {
                "Попова", "Иванова", "Краснова", "Селина", "Калиновская"
            };

            var language = (Language)_random.Next(0, 2);
            person.Gender = (Gender)_random.Next(0, 2);
            switch (person.Gender)
            {
                case Gender.Male:
                    switch (language)
                    {
                        case Language.English:
                            person.Name = maleNamesEng[_random.Next(maleNamesEng.Length)];
                            person.Surname = surnamesEng[_random.Next(surnamesEng.Length)];
                            break;
                        case Language.Russian:
                            person.Name = maleNamesRus[_random.Next(maleNamesRus.Length)];
                            person.Surname = maleSurnamesRus[_random.Next(maleSurnamesRus.Length)];
                            break;
                    }
                    break;

                case Gender.Female:
                    switch (language)
                    {
                        case Language.English:
                            person.Name = femaleNamesEng[_random.Next(femaleNamesEng.Length)];
                            person.Surname = surnamesEng[_random.Next(surnamesEng.Length)];
                            break;
                        case Language.Russian:
                            person.Name = femaleNamesRus[_random.Next(femaleNamesRus.Length)];
                            person.Surname = femaleSurnamesRus[_random.Next(femaleSurnamesRus.Length)];
                            break;
                    }
                    break;
            }
            person.Age = _random.Next(person.MinAge, person.MaxAge);
        }
        /// <summary>
        /// Метод: установка данных полей класса Adult.
        /// </summary>
        /// <param name="adult">Объект класса Adult.</param>
        public static void AdultRandom(Adult adult, Gender gender)
        {
            string[] companyNames = new string[]
            {
                "Пятерочка", "Газпром", "Сибур",
                "Томский политехнический университет", "Школа #34"
            };
            adult.Age = _random.Next(adult.MinAge, adult.MaxAge);
            adult.PassportID = _random.Next(Adult._minPassportID, Adult._maxPassportID);
            adult.Company = companyNames[_random.Next(companyNames.Length)];
            
            int marriegeStatus = _random.Next(0, 2);
            if (marriegeStatus == 0)
            {
                adult.Partner = new Adult();
                switch (adult.Gender)
                {
                    case Gender.Male:
                        {
                            adult.Partner = GetRandomAdult(Gender.Female);
                            break;
                        }
                    case Gender.Female:
                        {
                            adult.Partner = GetRandomAdult(Gender.Male);
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Метод: генерация случайного пола персоны.
        /// </summary>
        /// <param name="person">Объект класса PersonBase.</param>
        public static void SetGenderRandom(PersonBase person)
        {
            person.Gender = (Gender)_random.Next(2);
        }
        /// <summary>
        /// Перегруженный метод: получение объекта класса Adult.
        /// </summary>
        /// <param name="gender">Пол.</param>
        /// <returns>Объекта класса Adult</returns>
        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            SetGenderRandom(adult);
            GetRandomPerson(adult);
            AdultRandom(adult, gender);
            return adult;
        }

        /// <summary>
        /// Метод: установка данных полей класса Child.
        /// </summary>
        /// <param name="child">Объект класса Child.</param>
        public static void ChildRandom(Child child)
        {
            string[] schoolNames = new string[]
            {
                "Гриффиндор", "Слизерин", "Когтевран",
                "Пуффендуй", "Школа #34", "Лицей #1"
            };
            child.Age = _random.Next(child.MinAge, child.MaxAge);
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
        /// Метод получения рандомного объекта класса Child.
        /// </summary>
        /// <returns></returns>
        public static Child GetRandomChild()
        {
            Child child = new Child();
            SetGenderRandom(child);
            GetRandomPerson(child);
            ChildRandom(child);
            return child;
        }
    }
}


