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
    public class Adult : PersonBase
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
        public override int MinAge { get; } = _minAge;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public override int MaxAge { get; } = _maxAge;

        /// <summary>
        /// Минимальное значение серии паспорта
        /// </summary>
        public const int _minPassportID = 1000;

        /// <summary>
        /// Максимальное значение серии паспорта
        /// </summary>
        public const int _maxPassportID = 9999;

        //TODO +: XML
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public int PassportID
        {
            get => _passportID;

            set => _passportID = CheckPassportID(value);
        }

        //TODO +: XML
        /// <summary>
        /// Место работы
        /// </summary>
        public string Company
        {
            get => _company;

            set => _company = CheckValue(value);
        }

        //TODO +: XML
        /// <summary>
        /// Партнер
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
        /// Конструктор по умолчанию
        /// </summary>
        /*public Adult() : this("name", "sur", 18, Gender.Male,
            1110, "Job", null)
        { }*/
        public Adult()
        {
        }

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
                    ($"\nСерия паспорта должна быть числом " +
                    $"от {_minPassportID} до {_maxPassportID}");
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
            string smoking = smokingStatus[_random.Next(smokingStatus.Length)];
            return smoking;
        }

    }
}
