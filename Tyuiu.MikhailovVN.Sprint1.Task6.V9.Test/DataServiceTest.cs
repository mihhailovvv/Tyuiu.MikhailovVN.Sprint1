
using Tyuiu.MikhailovVN.Sprint1.Task6.V9.Lib;
namespace Tyuiu.MikhailovVN.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string strTest = "hello world привет";
            string wait = "ohell dworl тприве";
            string res = ds.MoveLetterToStart(strTest);
            Assert.AreEqual(wait, res);
        }
    }
}
