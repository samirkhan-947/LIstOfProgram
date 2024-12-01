internal class Program
{
    private static void Main(string[] args)
    {
        //A prime number is a natural number greater than 1 that has no divisors other than 1 and itself. In other words, a prime number is a number that cannot be formed by multiplying two smaller natural numbers.

        Console.WriteLine("Enter a number to check if it is a prime number:");

        // Read user input
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 1)
        {
            // Check if the number is prime
            bool isPrime = IsPrime(number);
            // Output the result
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer greater than 1.");
        }
         Console.ReadKey();
    }

    static bool IsPrime(int number)
    {
        if(number <= 1) return false; // Numbers <= 1 are not prime
        if(number == 2) return true; // 2 is a prime number
        if(number % 2 == 0) return false; // Even numbers other than 2 are not prime

        // Check divisors from 3 to sqrt(n)
        for(int i = 3; i <=Math.Sqrt(number); i+=2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}