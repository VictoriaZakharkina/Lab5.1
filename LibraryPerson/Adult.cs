using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
    /// <summary>
    /// Класс Adult
    /// </summary>
    public class Adult : Person
    {
        /// <summary>
        /// Серия паспорта
        /// </summary>
        private int _passportID;

        /// <summary>
        /// Место работы
        /// </summary>
        private string _company;

        /// <summary>
        /// Партнер
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        private const int _minAge = 18;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        private const int _maxAge = 150;

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        protected override int MinAge { get; } = _minAge;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        protected override int MaxAge { get; } = _maxAge;

        /// <summary>
        /// Минимальное значение серии паспорта
        /// </summary>
        private const int _minPassportID = 1000;

        /// <summary>
        /// Максимальное значение серии паспорта
        /// </summary>
        private const int _maxPassportID = 9999;

        /// <summary>
        /// Get, set Номер паспорта
        /// </summary>
        public int PassportID
        {
            get => _passportID;

            set => _passportID = CheckPassportID(value);
        }

        /// <summary>
        /// Get, set Место работы
        /// </summary>
        public string Company
        {
            get => _company;

            set => _company = CheckValue(value);
        }

        /// <summary>
        /// Get, set Партнер
        /// </summary>
        public Adult Partner
        {
            get => _partner;

            set
            {
                CheckPartnerGender(value);
                _partner = value;
            }
        }

        /// <summary>
        /// Информация о взрослом
        /// </summary>
        /// <returns>Информация</returns>
        public override string GetInfo()
        {
            string marriegeStatus = "Нет партнера";

            if (Partner != null)
            {
                marriegeStatus = $"В браке с {Partner.GetNameSurname()}";
            }

            string companyStatus = "Безработный";

            if (!string.IsNullOrEmpty(Company))
            {
                companyStatus = $"Работает в {Company}";
            }

            return $"{GetPersonInfo()}" +
                    $"\n{marriegeStatus},\n{companyStatus}";
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="passportID">Серия паспорта</param>
        /// <param name="company">Место работы</param>
        /// <param name="partner">Партнер</param>
        public Adult(string name, string surname, int age, Gender gender,
            int passportID, string company, Adult partner)
            : base(name, surname, age, gender)
        {
            PassportID = passportID;
            Company = company;
            Partner = partner;
        }

        /// <summary>
        /// Генератор случайных параметров
        /// </summary>
        private static Random rnd = new Random();

        /// <summary>
        /// Ввод случайного взрослого
        /// </summary>
        /// <returns>Случайный взрослый</returns>
        public static Adult GetRandomPerson(Gender gender)
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
            string[] companyNames = new string[]
            {
                "Пятерочка", "Газпром", "Сибур",
                "Томский политехнический университет", "Школа #34"
            };

            string name = string.Empty;
            string surname = string.Empty;
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
            int passportID = rnd.Next(_minPassportID, _maxPassportID);
            string company = companyNames[rnd.Next(companyNames.Length)];

            Adult partner = null;
            int marriegeStatus = rnd.Next(0, 2);
            if (marriegeStatus == 0)
            {
                partner = new Adult();
                if (gender == Gender.Male)
                {
                    partner.Gender = Gender.Female;
                    switch (language)
                    {
                        case Language.English:
                            partner.Name = femaleNamesEng[rnd.Next(femaleNamesEng.Length)];
                            partner.Surname = SurnamesEng[rnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            partner.Name = femaleNamesRus[rnd.Next(femaleNamesRus.Length)];
                            partner.Surname = femaleSurnamesRus[rnd.Next(femaleSurnamesRus.Length)];
                            break;
                    }

                }
                else
                {
                    partner.Gender = Gender.Male;
                    switch (language)
                    {
                        case Language.English:
                            partner.Name = maleNamesEng[rnd.Next(maleNamesEng.Length)];
                            partner.Surname = SurnamesEng[rnd.Next(SurnamesEng.Length)];
                            break;
                        case Language.Russian:
                            partner.Name = maleNamesRus[rnd.Next(maleNamesRus.Length)];
                            partner.Surname = maleSurnamesRus[rnd.Next(maleSurnamesRus.Length)];
                            break;
                    };
                }
            }

            return new Adult(name, surname, age, gender,
                            passportID, company, partner);
        }

        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <returns>Корректный возраст</returns>
        /// <exception cref="IndexOutOfRangeException">Некорректный возраст</exception>
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
        /// Проверка серии паспорта
        /// </summary>
        /// <param name="passportID">Серия паспорта</param>
        /// <returns>Корректная серия паспорта</returns>
        /// <exception cref="IndexOutOfRangeException">Некорректная серия паспорта</exception>
        private int CheckPassportID(int passportID)
        {
            if (passportID < _minPassportID || passportID > _maxPassportID)
            {
                throw new IndexOutOfRangeException
                    ($"\nThe passport should be in the " +
                    $"range from {_minPassportID} to {_maxPassportID}");
            }
            else
            {
                return passportID;
            }
        }

        /// <summary>
        /// Проверка пола партнера
        /// </summary>
        /// <param name="partner">Партнер</param>
        /// <exception cref="ArgumentException">Некорректный пол</exception>
        private void CheckPartnerGender(Adult partner)
        {
            if (partner != null && partner.Gender == Gender)
            {
                throw new ArgumentException
                    ("Однополые браки запрещены");
            }
        }

        /// <summary>
        /// Метод для взрослого
        /// </summary>
        /// <returns>Статус курения</returns>
        public string GetSmokingStatus()
        {
            string[] smokingStatus = new string[]
            {
                "курит", "не курит"
            };
            string smoking = smokingStatus[rnd.Next(smokingStatus.Length)];
            return smoking;
        }

        /// <summary>
        /// Неизвестный взрослый
        /// </summary>
        public Adult()
        {
        }


    }
}
