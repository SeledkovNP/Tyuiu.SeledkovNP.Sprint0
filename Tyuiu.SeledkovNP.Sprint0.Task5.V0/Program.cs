using Tyuiu.SeledkovNP.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A + B = " + DataService.Addition(10, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(10, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 5));
            Console.WriteLine("A / B = " + DataService.Division(10, 5));
            Console.WriteLine("A / 0 = " + DataService.Division(10, 0));

            Console.ReadKey();

        }
    }
}
