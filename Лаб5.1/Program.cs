namespace Лаб5._1
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Задание 1.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Вызов функции и вывод полученного результата.
        /// </summary>
        private static void Main()
        {
            string str1 = "активизация привет. " +
                "свет; " +
                "Искажение звука";
            string str2 = "активизация привет. " +
                "отсвет; " +
                "Искажение звука";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("Вывод слов, начинающихся с гласных букв:");
            foreach (var i in Vowels(str1, str2))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Вывод слов, начинающихся с согласных букв:");
            foreach (var i in Consonants(str1, str2))
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Создание списка, состоящего из слов, начинающихся на гласную букву.
        /// </summary>
        /// <param name="str1, str2">Входные строки.</param>
        /// <returns>l.</returns>
        private static List<string> Vowels(string str1, string str2)
        {
            // С помощью метода Split разделяем строку на подстроки.
            // Создаем массив, состоящий из гласных букв.
            // Создаем пустой список.
            string str3 = str1 + str2;
            string[] mystring = str3.Split(new[] { '.', ',', '?', '!', ';', ':', ' ', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            char[] vowers = { 'ё', 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'Ё', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю' };
            List<string> l = new List<string>();

            // Итерируемся по подстрокам, находим те слова, первая буква которых соотвествует массиву гласных букв.
            // В случае обнаружения добавляем данное слово в список.
            for (int i = 0; i < mystring.Length; i++)
            {
                for (int j = 0; j < vowers.Length; j++)
                {
                    if (mystring[i][0] == vowers[j])
                    {
                        l.Add(mystring[i]);
                    }
                }
            }

            return l;
        }

        private static List<string> Consonants(string str1, string str2)
        {
            // С помощью метода Split разделяем строку на подстроки.
            // Создаем массив, состоящий из согласных букв.
            // Создаем пустой список.
            string str3 = str1 + str2;
            string[] mystring = str3.Split(new[] { '.', ',', '?', '!', ';', ':', ' ', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'х', 'ч', 'щ', 'ш', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Х', 'Ч', 'Щ', 'Ш', };
            List<string> l = new List<string>();

            // Итерируемся по подстрокам, находим те слова, первая буква которых соотвествует массиву согласных букв.
            // В случае обнаружения добавляем данное слово в список.
            for (int i = 0; i < mystring.Length; i++)
            {
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (mystring[i][0] == consonants[j])
                    {
                        l.Add(mystring[i]);
                    }
                }
            }

            return l;
        }
    }
}
