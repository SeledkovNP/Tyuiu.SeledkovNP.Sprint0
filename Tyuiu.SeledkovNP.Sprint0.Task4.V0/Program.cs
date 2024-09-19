using Tyuiu.SeledkovNP.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SeledkovNP.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));              //  +

            Console.WriteLine(DataService.Subtraction(1, 5));                 //   -

            Console.WriteLine(DataService.Multiplication(10, 5));                //  *

            Console.WriteLine(DataService.Division(10, 5));              // ( / )

            Console.ReadKey();
        }
    }
}
