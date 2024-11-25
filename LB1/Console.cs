using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    /// <summary>
    /// Класс ReaderFromConcole
    /// </summary>
    public class ReaderFromConcole
    {
        /// <summary>
        /// Ввод параметров шара
        /// </summary>
        /// <returns>Объект класса Sphere</returns>
        public static Sphere GetVolumeSphere()
        {
            Sphere sphere = new Sphere();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите радиус шара (см): ");
                    sphere.Radius = Convert.ToDouble(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return sphere;
        }

        /// <summary>
        /// Ввод параметров пирамиды
        /// </summary>
        /// <returns>Объект класса Pyramid</returns>
        public static Pyramid GetVolumePyramid()
        {
            Pyramid pyramid = new Pyramid();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите площадь основания пирамиды (см^2): ");
                    pyramid.AreaOfBase = Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите высоту пирамиды (см): ");
                    pyramid.Height = Convert.ToDouble(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return pyramid;
        }

        /// <summary>
        /// Ввод параметров параллелепипеда
        /// </summary>
        /// <returns>Объект класса Parallelepiped</returns>
        public static Parallelepiped GetVolumeParallelepiped()
        {
            Parallelepiped parallelepiped = new Parallelepiped();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите длину параллелепипеда (см): ");
                    parallelepiped.Length = Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите ширину параллелепипеда (см): ");
                    parallelepiped.Width = Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите высоту параллелепипеда (см): ");
                    parallelepiped.Height = Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите угол между длиной и шириной параллелепипеда (град): ");
                    parallelepiped.AngleLengthWidth = Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите угол между длиной и высотой параллелепипеда (град): ");
                    parallelepiped.AngleBaseHeight = Convert.ToDouble(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return parallelepiped;
        }

        /// <summary>
        /// Определение объёма фигуры
        /// </summary>
        /// <returns>Объем</returns>
        /// <exception cref="ArgumentException">Некорректный ввод</exception>
        public static FigureBase GetVolumeFigure()
        {
            FigureBase volume = new Sphere();

            var actions = new List<Action>()
            {
                () =>
                {
                    Console.WriteLine(
                        "\nВыберите фигуру, для которой рассчитаем объем:\n" +
                        "1 - Шар\n" +
                        "2 - Пирамида\n" +
                        "3 - Параллелепипед\n");
                },

                () =>
                {
                    ConsoleKeyInfo number = Console.ReadKey();
                    switch (number.KeyChar)
                    {
                        case '1':
                        {
                            Console.WriteLine(" Расчет объема шара.");
                            volume = GetVolumeSphere();
                            break;
                        }

                        case '2':
                        {
                            Console.WriteLine(" Расчет объема пирамиды.");
                            volume = GetVolumePyramid();
                            break;
                        }

                        case '3':
                        {
                            Console.WriteLine(" Расчет объема параллелепипеда.");
                            volume = GetVolumeParallelepiped();
                            break;
                        }

                        default:
                        {
                            throw new ArgumentException(
                                "\nВыберите для какой фигуры нужно расчитать объем.");
                        }
                    }
                },
            };

            ActionHandler(actions);

            return volume;
        }

        /// <summary>
        /// Обработчик действий
        /// </summary>
        /// <param name="actions">Список действий</param>
        private static void ActionHandler(List<Action> actions)
        {
            foreach (var action in actions)
            {
                while (true)
                {
                    try
                    {
                        action.Invoke();
                        break;
                    }
                    catch (FormatException ex)
                    {
                        HandleFormatException(ex);
                    }
                    catch (ArgumentException ex)
                    {
                        HandleArgumentException(ex);
                    }
                    catch (Exception ex)
                    {
                        HandleGenericException(ex);
                    }
                }
            }
        }

        /// <summary>
        /// Проверка данных
        /// </summary>
        /// <param name="ex">Некорректный ввод</param>
        private static void HandleFormatException(FormatException ex)
        {
            Console.WriteLine("Некорректный формат ввода. " + ex.Message);
        }

        /// <summary>
        /// Проверка аргумента
        /// </summary>
        /// <param name="ex">Некорректный ввод</param>
        private static void HandleArgumentException(ArgumentException ex)
        {
            Console.WriteLine("Неверный аргумент. " + ex.Message);
        }

        /// <summary>
        /// Другие ошибки
        /// </summary>
        /// <param name="ex">Возникновение ошибки</param>
        private static void HandleGenericException(Exception ex)
        {
            Console.WriteLine("Произошла ошибка. " + ex.Message);
        }
    }
}