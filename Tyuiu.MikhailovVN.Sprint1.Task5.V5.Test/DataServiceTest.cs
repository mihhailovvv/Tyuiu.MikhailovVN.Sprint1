
using Tyuiu.MikhailovVN.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            double wait = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
            
        }
    }
}
