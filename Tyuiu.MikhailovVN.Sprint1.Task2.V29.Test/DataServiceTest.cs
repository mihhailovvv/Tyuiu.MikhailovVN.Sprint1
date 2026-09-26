
using Tyuiu.MikhailovVN.Sprint1.Task2.V29.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 120;
            var res = ds.ConvertSecondsToHours(value);
            Assert.AreEqual(2, res);
        }
    }
}
