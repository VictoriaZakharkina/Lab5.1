using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Library;

namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
	internal class Program
    {
        /// <summary>
        /// Метод Main
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Для начала работы нажмите 1\nДля выхода нажмите 2");
                ConsoleKeyInfo number = Console.ReadKey(true);

                switch (number.KeyChar)
                {
                    //TODO +: RSDN
                    case '1':
                    {
                        break;
                    }
                    case '2':
                    {
                        return;
                    }
                    default:
                    {
                        Console.WriteLine("Ошибка! Введите цифру 1 или 2\n");
                        continue;
                    }
                }

                FigureBase volume = ReaderFromConcole.GetVolumeFigure();
                Console.WriteLine($"Объем выбранной фигуры: " +
                    $"{Math.Round(volume.Volume, 2)} см^3\n");
            }
        }
    }
}
