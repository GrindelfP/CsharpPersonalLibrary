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
    public static Array ArrayInput(string arrayType)
    {
        Print("Print the length of your array: ");
        var arrayLength = IntInput();
        PrintLn("Enter numbers of your array in the following lines:");
        var array = new object[arrayLength];
        switch (arrayType)
        {
            case "string":
            {
                for (var i = 0; i < arrayLength; i++) array[i] = StrInput();
                break;
            }
            case "number":
            {
                for (var i = 0; i < arrayLength; i++) array[i] = DoubleInput();
                break;
            }
            default:
            {
                for (var i = 0; i < arrayLength; i++) array[i] = BooleanInput();
                break;
            }
        }
        return array;
    }
}