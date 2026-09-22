
using Tyuiu.MikhailovVN.Sprint1.Task0.V26.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dss = new DataService();
            var res = dss.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
