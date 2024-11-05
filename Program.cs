namespace Assignments_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple console application and store your name, age (should take decimal), address in a string variable and print them back on console. Prompt the user to each time enter name, age and address.
            Console.WriteLine("Pls enter your name: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Pls enter your age: ");
            double myAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pls enter your address: ");
            string myAddress = Console.ReadLine();

            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age: " + myAge);
            Console.WriteLine("Address: " + myAddress);

            //Write a C# Sharp program to print the sum of two numbers.
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine("The sum is: " + sum);

            //Write a C# Sharp program to print the result of dividing two numbers.
            Console.WriteLine("Enter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            double result = dividend / divisor;
            Console.WriteLine("The result: " + result);

            }

    }
}
