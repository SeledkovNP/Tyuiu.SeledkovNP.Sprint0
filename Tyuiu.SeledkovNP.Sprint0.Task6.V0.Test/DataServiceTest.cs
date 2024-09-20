using Tyuiu.SeledkovNP.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayVailid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);

        }

        public void CheckSubstractionArrayVailid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);

        }

        public void CheckMultArrayVailid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);

        }

    }
}