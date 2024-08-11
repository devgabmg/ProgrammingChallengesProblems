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

            if (!int.TryParse(args[0], out int i))
            {
                Console.WriteLine("Error, please enter a valid value for first number");
                return;
            }

            if (!int.TryParse(args[1], out int j))
            {
                Console.WriteLine("Error, please enter a valid value for second number");
                return;
            }

            if (i > j)
            {
                Console.WriteLine("Error, please enter two valid number, such that number1 < number2");
                return;
            }

            var cycleLengths = new int[j - i + 1];
            var cycleLengthsIndex = 0;
            for (int count = i; count <= j; count++)
            {
                cycleLengths[cycleLengthsIndex++] = GetCycleLength(count);
            }
            var maxCycleLength = cycleLengths.Max();
            Console.WriteLine($"{i} {j} {maxCycleLength}");
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
    }
}
