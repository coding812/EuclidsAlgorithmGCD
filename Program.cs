public class Program
{
    // Method to prompt user for input, converted to "int",
    // and assign to variables
    static int GetInput(out int a, out int b)
    {
        a = 0;
        b = 0;

        Console.Write("First number: ");
        var y = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        var z = int.Parse(Console.ReadLine());

        a = y; b = z;

        return a;
        return b;
    }

    //Method to find greatest common divisor of any two
    //given numbers, assigns result to variable
    static int GreatestCommonDivisor(int a, int b)
    {
        // Gets remainder of when "a"
        // is divided by "b" and assigns it to "r"
        int r = a % b;

        // Ensures "a" is always
        // the larger number
        if (b > a)
        {
            a = b; b = a;
        }

        // As long as "r" is not equal to zero, repeats
        // Euclid's method for finding GCD
        // If "r" does equal zero, loop never runs
        // and skips to printing "b" as the GCD
        while (r != 0)
        {
            a = b; b = r;
            r = a % b;
        }

        int divisor = b;
        return divisor;
    }

    public static void Main(string[] args)
    {
        int a, b;
        
        try
        {
            Console.WriteLine("Give me two numbers and I'll give you their greatest common divisor! ");

            _ = GetInput(out a, out b);

            int result = GreatestCommonDivisor(a, b);

            Console.WriteLine(string.Format("The Greatest Common Divisor of " +
                "{0} and {1} is {2}.", a, b, result));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("I'm sorry, you can't divide by zero, Please enter only positive" +
                " integers (Whole numbers greater than zero)");

            _ = GetInput(out a, out b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter only positive integers (Whole numbers greater than zero)");

            _ = GetInput(out a, out b);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Please enter only positive integers (Whole numbers greater than zero)");

            _ = GetInput(out a, out b);
        } 
    }
}