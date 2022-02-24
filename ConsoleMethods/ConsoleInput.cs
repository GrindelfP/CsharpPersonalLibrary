using static ConsoleMethods.ConsoleOutput;

namespace ConsoleMethods;

public static class ConsoleInput
{
    // Methods for getting user's console input.
    public static string StrInput()
    {
        string? input = Console.ReadLine();
        if (input == null) return "";
        else return input;
    }

    public static int IntInput()
    {
        while (true)
        {
            var input = Console.ReadLine();
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                // ignored
            }
        }
    }

    public static long LongInput()
    {
        while (true)
        {
            var input = Console.ReadLine();
            try
            {
                return Convert.ToInt64(input);
            }
            catch
            {
                // ignored
            }
        }
    }

    public static double DoubleInput()
    {
        while (true)
        {
            var input = Console.ReadLine();
            try
            {
                return Convert.ToDouble(input);
            }
            catch
            {
                // ignored
            }
        }
    }

    public static bool BooleanInput()
    {
        while (true)
        {
            var input = Console.ReadLine();
            try
            {
                return Convert.ToBoolean(input);
            }
            catch
            {
                // ignoredIntInput
            }
        }
    }

    private static int GetArrayLength()
    {
        Print("Print the length of your array: ");
        var arrayLength = IntInput();
        return arrayLength;
    }

    public static double[] ArrayNumInput()
    {
        var arrayLength = GetArrayLength();
        var array = new double[arrayLength];
        PrintLn("Enter numbers of your array in the following lines:");
        for (var i = 0; i < arrayLength; i++) array[i] = DoubleInput();
        return array;
    }

    public static string[] ArrayStrInput()
    {
        var arrayLength = GetArrayLength();
        var array = new string[arrayLength];
        PrintLn("Enter numbers of your array in the following lines:");
        for (var i = 0; i < arrayLength; i++) array[i] = StrInput();
        return array;
    }

    public static bool[] ArrayBoolInput()
    {
        var arrayLength = GetArrayLength();
        var array = new bool[arrayLength];
        PrintLn("Enter numbers of your array in the following lines:");
        for (var i = 0; i < arrayLength; i++) array[i] = BooleanInput();
        return array;
    }
}