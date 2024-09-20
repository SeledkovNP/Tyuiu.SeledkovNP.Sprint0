using Tyuiu.SeledkovNP.Sprint0.Task7.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DatsServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysVailid()
        {

            int[] numbers1 = new int[] { 1, 1, 1, 1, 1 };
            int[] numbers2 = new int[] { 1, 1, 1, 1, 1 };
            int[] numbers3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(numbers1, numbers2);
            CollectionAssert.AreEqual(numbers3, res);

        }
    }
}