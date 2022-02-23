namespace ConsoleMethods;

public static class ConsoleOutput
{
    // Methods for printing text in console.
    public static void PrintLn(object @string) => Console.WriteLine(@string);
    public static void Print(object @string) => Console.Write(@string);
    public static void PrintArray(Array array)
    {
        foreach (var item in @array) Console.Write("{0} ", item);
    }
}