class Program
{
    static void Main(string[] args)
    {
        int a, b;

        GetInput(out a, out b);

        int result = GreatestCommonDivisor(a, b);

        Console.WriteLine(string.Format("The Greatest Common Divisor of {0} and {1} is {2}.", a, b, result));
    }

    
    
    
    // Method to prompt user for input, converted to "int", and assign to variables
    static void GetInput(out int a, out int b)
    {
        Console.WriteLine("Give me two numbers and I'll give you their greatest common divisor!");
        Console.Write("First number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        b = int.Parse(Console.ReadLine());
    }
    
    //Method to find greatest common divisor of any two given numbers, assigns result to variable
    static int GreatestCommonDivisor(int a, int b)
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