
using Tyuiu.MikhailovVN.Sprint1.Task4.V29.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 0.167;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
