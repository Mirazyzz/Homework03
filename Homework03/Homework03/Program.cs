namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int firstNumber);
            int.TryParse(Console.ReadLine(), out int secondNumber);

            int s;
            Console.WriteLine($"Javob: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}.");
        }
    }
}