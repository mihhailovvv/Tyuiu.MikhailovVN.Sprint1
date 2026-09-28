
using Tyuiu.MikhailovVN.Sprint1.Task3.V19.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Михайлов В. Н. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваения                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости от    *");
            Console.WriteLine("* того, может ли шахматная фигура «Слон» с одного заданного поля          *");
            Console.WriteLine("* шахматной доски перейти за один ход на другое. Пользователь задаёт      *");
            Console.WriteLine("* координаты двух ячеек шахматной доски (x1 и y1, x2 и y2, каждое в       *");
            Console.WriteLine("* диапазоне от 1 до 8).                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x1 (от 1 до 8): ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y1 (от 1 до 8): ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение x2 (от 1 до 8): ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y2 (от 1 до 8): ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + ds.ElephCanMove(x1, x2, y1, y2));




        }
    }
}
