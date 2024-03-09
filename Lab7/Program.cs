namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath calculator = new BasicMath();

            //input first number
            Console.WriteLine("Please enter a first number:");
            double num1;
            //ensure it is double, if not ask again
            while(!double.TryParse(Console.ReadLine(), out num1))
            { 
                Console.WriteLine("Please enter a valid number:");
            }
            //input second number
            Console.WriteLine("Please enter a second number:");
            double num2;
            //ensure it is double, if not ask again
            while (!double.TryParse(Console.ReadLine(), out num2))
            { 
                Console.WriteLine("Please enter a valid number:");
            }
            //divison method for practice
            try
            {
                double result = calculator.Division(num1, num2);
                Console.WriteLine($"The result is: {result}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
