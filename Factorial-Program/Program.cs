internal class Program
{
    private static void Main(string[] args)
    {
        //The factorial of a non-negative integer 𝑛 n is the product of all positive integers less than or equal to n. It is denoted by 𝑛 ! n!.
        int n, fact = 1;
        Console.WriteLine("Enter the number:");
        n = Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=n; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + n + " is " + fact);
        Console.ReadKey(true);
    }
}