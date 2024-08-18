namespace Problem1._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Error, please enter two valid number, such that number1 < number2");
                return;
            }

            if (!int.TryParse(args[0], out int number1))
            {
                Console.WriteLine("Error, please enter a valid value for first number");
                return;
            }

            if (!int.TryParse(args[1], out int number2))
            {
                Console.WriteLine("Error, please enter a valid value for second number");
                return;
            }

            if (number1 > number2)
            {
                Console.WriteLine("Error, please enter two valid number, such that number1 < number2");
                return;
            }

            var maximumCycleLength = GetMaximumCycleLength(number1, number2);
            Console.WriteLine($"{number1} {number2} {maximumCycleLength}");
        }

        public static int GetCycleLength(int n)
        {
            var cycleLength = 1;
            while (n != 1)
            {
                n = (n % 2 == 0) ? n / 2 : n * 3 + 1;
                cycleLength++;
            }
            return cycleLength;
        }

        public static int GetMaximumCycleLength(int number1, int number2)
        {
            int maximumCycleLength = 0;
            for (int i = number2; i >= number1; i--)
            {
                int cycleLength = GetCycleLength(i);
                maximumCycleLength = cycleLength > maximumCycleLength ? cycleLength : maximumCycleLength;
            }
            return maximumCycleLength;
        }
    }
}
