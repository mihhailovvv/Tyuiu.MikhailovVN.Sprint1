
using Tyuiu.MikhailovVN.Sprint1.Task1.V12.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate_1()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 6.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
