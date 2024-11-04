namespace Assignments_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter your name: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Pls enter your age: ");
            double myAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pls enter your address: ");
            string myAddress = Console.ReadLine();

            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age: " + myAge);
            Console.WriteLine("Address: " + myAddress);
        }
    }
}
