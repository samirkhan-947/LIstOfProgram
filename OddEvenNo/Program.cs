internal class Program
{
    private static void Main(string[] args)
    {
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