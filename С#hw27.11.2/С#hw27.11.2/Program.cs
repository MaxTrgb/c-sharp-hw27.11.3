namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number:");

            string userInput = Console.ReadLine();
            int number;

            while (!int.TryParse(userInput, out number) || userInput.Length != 6)
            {
                Console.WriteLine("Invalid input. Please enter a six-digit number:");
                userInput = Console.ReadLine();
            }

            int reversedNumber = ReverseNumber(number);

            Console.WriteLine($"Reversed number: {reversedNumber}");
        }

        private static int ReverseNumber(int num)
        {
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num = num / 10;
            }

            return reversedNum;
        }
    }
}
