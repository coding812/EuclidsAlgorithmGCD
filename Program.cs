internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Give me two numbers and I'll give you their greatest common divisor!");
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());

        int result = GreatestCommonDivisor(a, b);

        Console.WriteLine(string.Format("The Greatest Common Divisor of {0} and {1} is {2}.", a, b, result));
    }

    private static int GreatestCommonDivisor(int a, int b)
    {
        // Gets remainder of when "a" is divided by "b" and assigns it to "r"
        int r = a % b;

        // ensures "a" is always the larger number
        if (b > a)
        {
            a = b; b = a;
        }

        // As long as "r" is not equal to zero, repeats Euclid's method for finding GCD
        // If "r" does equal zero, loop never runs and skips to printing "b" as the GCD
        while (r != 0)
        {
            a = b; b = r;
            r = a % b;
        }

        int divisor = b;
        return divisor;
    }
}