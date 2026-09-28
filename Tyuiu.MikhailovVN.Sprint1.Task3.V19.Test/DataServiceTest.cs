
using Tyuiu.MikhailovVN.Sprint1.Task3.V19.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 2;
            double y1 = 3;
            double y2 = 4;
            bool res = ds.ElephCanMove(x1, y1, x2, y2);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
