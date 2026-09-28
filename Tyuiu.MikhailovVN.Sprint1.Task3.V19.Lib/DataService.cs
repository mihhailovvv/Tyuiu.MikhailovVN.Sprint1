
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailovVN.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            if (x1 < 1 || x1 > 8 || x2 < 1 || x2 > 8 || y1 < 1 || y1 > 8 || y2 < 1 || y2 > 8)

            {
                return false;
            }

            if (x1 == x2  && y1 == y2)
            {
                return false;
            }

            return Math.Abs(x1- x2) == Math.Abs(y1- y2);
        }
    }
}
