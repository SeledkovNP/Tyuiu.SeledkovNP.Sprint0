using Tyuiu.SeledkovNP.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5, };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Раззность элементов массива = " + DataService.SubstractionArray(numsArray));

            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
