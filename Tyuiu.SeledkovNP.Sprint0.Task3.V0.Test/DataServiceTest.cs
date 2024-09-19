using Tyuiu.SeledkovNP.Sprint0.Task3.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedVaild()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}