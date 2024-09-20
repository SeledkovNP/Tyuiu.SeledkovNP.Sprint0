namespace Tyuiu.SeledkovNP.Sprint0.Task7.V0.Lib
{
    public class DataService
    {


        public static int Addition(int a, int b)
        { return a + b; }

        public static int Subtraction(int a, int b)
        { return a - b; }

        public static int Multiplication(int a, int b)
        { return a * b; }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b == {0} на ноль делить нельзя", b);
                return -1;
            }

            else
            {
                return a / b;
            }
        }

        public static object AdditionArrays(int[] numbers)
        {
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }

        public static object SubstractionArrays(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {

                total = total - numbers[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArrays(int[] numbers)
        {
            var total = 1;
            int index = 0;

            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }

        public static int[] AdditionArrays(int[] numbers1, int[] numbers2)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numbers1[i] + numbers2[i];
            }
            return resultArray;
        }


        
    }
}
