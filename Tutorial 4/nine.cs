using System;

class P9
{
    public static void nines()
    {
        Console.WriteLine("Kalariya Marmik S." + "25SOECE13063");
        int x = 0;
        try
        {
            // This statement causes DivideByZeroException
            int div = 100 / x;

            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            // Handle division by zero
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            // This block always executes
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program completed.");
        Console.Read();
    }
}