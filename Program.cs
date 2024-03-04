namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath calculator = new BasicMath();

            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = calculator.Addition(num1, num2);
            Console.WriteLine($"The result is: {result}");
        }
    }
}
