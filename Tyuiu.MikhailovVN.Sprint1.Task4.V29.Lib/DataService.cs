
using System.Transactions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MikhailovVN.Sprint1.Task4.V29.Lib
{
    public class DataService : ISprint1Task4V29
    {
        public double Calculate(double x, double y)
        {
            double chisl = Math.Sqrt(2 + Math.Abs(x - 2 * y));
            double znamen = 3 * x * Math.Pow(y, 2);
            return Math.Round(chisl / znamen, 3);
        }
    }
}
