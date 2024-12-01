internal class Program
{
    private static void Main(string[] args)
    {
        //The program checks if the number is divisible by 2 using the modulo operator (%).
        //If number % 2 == 0, the number is even; otherwise, it is odd.

        int x;
        Console.WriteLine("Enter the No");
        x = Convert.ToInt32(Console.ReadLine());
        if(x%2 == 0)
        {
            Console.WriteLine("Number is Even No");
        }
        else
        {
            Console.WriteLine("Number is Odd No");
        }
        Console.ReadKey();
    }
}